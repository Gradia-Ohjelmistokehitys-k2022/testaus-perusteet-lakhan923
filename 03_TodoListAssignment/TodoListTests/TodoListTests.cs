using TestingTodoListApp;

namespace TodoListTests
{
    [TestClass]
    public class TodoListTests
    {

        [TestMethod]
        public void AddItemToList_IncrementCounterAndSetId()
        {
            //Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Do the dishes", DateTime.Now);

            //Act
            todoList.AddItemToList(task);

            //Assert
            Assert.AreEqual(1, todoList._TodoItems.Count, "Item was not added to the list.");
            Assert.AreEqual(0, task.Id, "TodoTask Id was not set correctly.");
        }


        [TestMethod]
        public void RemoveItemFromList_DecrementCounterAndReEmoveItem()
        {
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Do the dishes", DateTime.Now);

            todoList.AddItemToList(task);
            int initialCounter = todoList._TodoItems.Count;

            todoList.RemoveItemFromList(task);

            Assert.AreEqual(1, todoList._TodoItems.Count, "Item was not removed from the list.");
            Assert.AreEqual(0, task.Id, "TodoTask Id was not reset correctly.");
        }


        [TestMethod]
        public void CompleteItem_SetIsCompletedToTrue()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("New Task", DateTime.Now);
            todoList.AddItemToList(task);

            // Act
            todoList.CompleteItem(task.Id);

            //Assert
            Assert.IsFalse(todoList.All.Contains(task));
        }
    }
}


