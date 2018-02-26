using Google.Cloud.Datastore.V1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Task
{
    /// <summary>
    ///  PI Engineering & Cloud Comp (SEC. 001)
    ///  Assignment 2 - Task -2017-09-25
    ///  Author: FABIO ALEXANDRE CICONI - 300930989
    /// </summary>
    public partial class FormTask : Form
    {
        /// <summary>
        /// Global Variables
        /// </summary>
        private readonly DatastoreDb db;
        private readonly KeyFactory keyFactory;
        private const string PROJECT_ID = "ciconi-1";
        private const string KIND = "Task";


        public FormTask()
        {
            InitializeComponent();
            db = DatastoreDb.Create(PROJECT_ID);
            keyFactory = db.CreateKeyFactory(KIND);
        }
        
        /// <summary>
        /// LIST ALL ELEMENTS IN THE TABLE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonList_Click(object sender, EventArgs e)
        {
            dataGridViewTasks.Rows.Clear();

            var task = ListTasks();

            foreach (Entity t in ListTasks())
            {
                IDictionary<string, object> path = Json.JsonParser.FromJson(t.Key.Path.ToString());
                object array0 = ((IDictionary<string, object>)path)["array0"];
                List<object> array = (List<object>)array0;


                object id = ((IDictionary<string, object>)array[0])["id"];


                IDictionary<string, object> entity = Json.JsonParser.FromJson(t.ToString());
                object properties = entity["properties"];

                IDictionary<string, object> description = (IDictionary<string, object>)((IDictionary<string, object>)properties)["Description"];

                IDictionary<string, object> createdBy = (IDictionary<string, object>)((IDictionary<string, object>)properties)["CreatedBy"];

                IDictionary<string, object> created = (IDictionary<string, object>)((IDictionary<string, object>)properties)["Created"];

                IDictionary<string, object> done = (IDictionary<string, object>)((IDictionary<string, object>)properties)["Done"];

                string time = (string)created["TimestampValue"];

                dataGridViewTasks.Rows.Add(id, description["StringValue"], DateTime.Parse(time), createdBy["StringValue"], (bool)done["BooleanValue"] ? "Yes" : "No");

                dataGridViewTasks.Update();

            }
        }
        /// <summary>
        /// ADD new task to the Datastore
        /// </summary>
        /// <param name="createby"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        private Key AddTask(string createby, string description)
        {
            Entity task = new Entity()
            {
                Key = keyFactory.CreateIncompleteKey(),
                ["Description"] = new Value()
                {
                    StringValue = description,
                    ExcludeFromIndexes = true
                },
                ["Created"] = DateTime.UtcNow,
                ["CreatedBy"] = createby,
                ["Done"] = false
            };
           
            MessageBox.Show("New task added");
            return db.Insert(task);

        }
        /// <summary>
        /// update task as done
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///  UpdateTask(idSelected, createdby, desc, done);
        private bool UpdateTask(long id,string createby, string description, bool done)
        {
            using (var transaction = db.BeginTransaction())
            {
                Entity task = transaction.Lookup(keyFactory.CreateKey(id));
                if (task != null)
                {
                    task["Done"] = done;
                    task["CreatedBy"] = createby;
                    task["Description"] = description;
                    transaction.Update(task);
                }
                transaction.Commit();
                MessageBox.Show("Task Updated");
                return task != null;

            }

        }
        //private bool MarkDone(long id)
        //{
        //    using (var transaction = db.BeginTransaction())
        //    {
        //        Entity task = transaction.Lookup(keyFactory.CreateKey(id));
        //        if (task != null)
        //        {
        //            task["Done"] = true;
        //            transaction.Update(task);
        //        }
        //        transaction.Commit();
        //        MessageBox.Show("Task Updated");
        //        return task != null;                
        //    }
        //}
        /// <summary>
        /// delete task
        /// </summary>
        /// <param name="id"></param>
        private void DeleteTask(long id)
        {            
            db.Delete(keyFactory.CreateKey(id));
            MessageBox.Show("Task Deleted");
        }       
        /// <summary>
        /// Returns a list of all task entities in ascending order of creation time.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Entity> ListTasks()
        {


            Query query = new Query("Task")
            {
                Order = { { "CreatedBy", PropertyOrder.Types.Direction.Descending } }
            };

            return db.RunQuery(query).Entities;

        }
        /// <summary>
        /// Finish application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string desc = textBoxDesc.Text;
                string createby = textBoxCreateBy.Text;
                if ((desc == "") || (createby == ""))
                {
                    MessageBox.Show("Please insert all fields");
                }
                else
                {
                    AddTask(createby, desc);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex);
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewTasks.Rows.Clear();
            textBoxID.Text = "";
            textBoxDesc.Text = "";
            textBoxCreateBy.Text = "";
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var idSelected = long.Parse(dataGridViewTasks.SelectedCells[0].Value.ToString());
                DeleteTask(idSelected);
            }
            catch (Exception)
            {

                MessageBox.Show("There is nothing to delete", "Warning");
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
                var idSelected = long.Parse(dataGridViewTasks.SelectedCells[0].Value.ToString());
                var desc = textBoxDesc.Text;
                var createdby = textBoxCreateBy.Text;
                var done = false;
            if (checkBoxDone.Checked == true)
            {
                done = true;
            }
                UpdateTask(idSelected, createdby, desc, done);
           
        }        
        private void dataGridViewTasks_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = dataGridViewTasks.SelectedCells[0].Value.ToString();
                textBoxDesc.Text = dataGridViewTasks.SelectedCells[1].Value.ToString();
                textBoxCreateBy.Text = dataGridViewTasks.SelectedCells[3].Value.ToString();
                if (dataGridViewTasks.SelectedCells[4].Value.ToString() == "Yes")
                {
                    checkBoxDone.Checked = true;
                }
            }
            catch (Exception)
            {


                MessageBox.Show("There is no value in the line","Warning");
            }
        }
    }

}
