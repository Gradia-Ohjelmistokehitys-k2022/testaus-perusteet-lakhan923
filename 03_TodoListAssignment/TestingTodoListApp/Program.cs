using System.Collections.Generic;
using System.Linq;
using TestingTodoListApp;

namespace TodoListNS
{

    /// <summary>
    /// Todo list. You can inserts things to do. Delete them. Complete them.
    /// </summary>
    public class Program
    {

        public static void Main()
        {
            TodoList todoList = new TodoList();

            todoList.AddItemToList(new TodoTask("Do the dishes", new DateTime()));
            todoList.AddItemToList(new TodoTask("Wash your clothes",new DateTime()));
            IEnumerable<TodoTask> list = todoList.All; //for iterations
            List<TodoTask> anotherList = todoList._TodoItems; //original style of getting list
            foreach (TodoTask item in list)
            {
                Console.WriteLine(item);
            }

            foreach (TodoTask item in anotherList)
            {
                Console.WriteLine(item);
            }

        }

    }
}
