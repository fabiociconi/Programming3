//  Adds a task entity to the Datastore
// <param name="description">The taskdescription.</param>
// <returns>The key of the entity.</returns>
Key AddTask(string description)
{
    Entity task = new Entity()
    {
        Key = _keyFactory.CreateIncompleteKey(),
        ["description"] = new Value()
        {
            StringValue = description,
            ExcludeFromIndexes = true
        },
        ["created"] = DateTime.UtcNow,
		["CreateBy"] ="Yin Li",
        ["done"] = false
    };
    return _db.Insert(task);
}

// Marks a task entity as done.
// <param name="id">The ID of the task entity as given by Key.</param>
// <returns>true if the task was found.</returns>
bool MarkDone(long id)
{
    using (var transaction = _db.BeginTransaction())
    {
        Entity task = transaction.Lookup(_keyFactory.CreateKey(id));
        if (task != null)
        {
            task["done"] = true;
            transaction.Update(task);
        }
        transaction.Commit();
        return task != null;
    }
}


// Deletes a task entity.
// <param name="id">The ID of the task entity as given by Key.</param>
void DeleteTask(long id)
{
    _db.Delete(_keyFactory.CreateKey(id));
}


// Returns a list of all task entities in ascending order of creation time.

IEnumerable<Entity> ListTasks()
{
    Query query = new Query("Task")
    {
        Order = { { "created", PropertyOrder.Types.Direction.Descending } }
    };
    return _db.RunQuery(query).Entities;
}