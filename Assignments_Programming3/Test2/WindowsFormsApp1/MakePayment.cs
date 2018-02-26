using DataBaseLibrary_Test2;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class MakePayment : Form
    {

        private string accountIdLogged = FormLogin.loginInformation;//pega informacao do outro form 

        private AMSEntities dbcontext = new AMSEntities();

        public MakePayment()
        {
            InitializeComponent();           
        }

        private void MakePayment_Load(object sender, EventArgs e)
        {
            var bankAccoutInfo = from accounts in dbcontext.Account
                                 orderby accounts.AccountNo
                                 where accounts.ClientID == accountIdLogged
                                 select new{ Number_Account = accounts.AccountNo + 
                                            "-" + accounts.AccountType,
                                            Total_Amount = accounts.Balance};

            foreach (var item in bankAccoutInfo)
            {
                comboBoxAccount.Items.Add(item.Number_Account);

                comboBoxAccount.SelectedIndex = -1;
            }
        }

        private void comboBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string infoAccounts = comboBoxAccount.Text.Substring(0, 8);
            var allAccountInformations =
                from account in dbcontext.Account
                select account;

            foreach (var item in allAccountInformations)
            {
                if (infoAccounts == item.AccountNo)
                {
                    textBoxBalance.Text = item.Balance.ToString();
                    return;
                }
            }
        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            string bankAccount = comboBoxAccount.Text.Substring(0, 8);
            decimal ammountToPay;

            if (textBoxAmount.Text != "")
            {
                ammountToPay = Convert.ToDecimal(textBoxAmount.Text);
                var Check = from account in dbcontext.Account
                            where account.AccountNo == bankAccount
                            select account;

                foreach (var item in Check)
                {
                    if (ammountToPay > item.Balance)
                    {
                        MessageBox.Show("Not enough money");
                        return;
                    }
                    if ((ammountToPay <= item.Balance) && (bankAccount == item.AccountNo))
                    {
                        decimal newValue = item.Balance - ammountToPay;
                        item.Balance = newValue;
                        //dbcontext.SaveChanges();
                        MessageBox.Show("You pay your Debit and The NewBalance is:" + item.Balance);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("ERROR..........");
                    }
                }
            }
            else
            {
                MessageBox.Show("Insert The Ammount to Pay");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
