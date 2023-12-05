using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestingTodoListApp
{
    public record TodoTask //find out about the function of the record
    {

        public int Id { get; init; }
        public string TaskDescription { get; init; }
        public DateTime DueDate { get; init; } // Add DueDate property
        public bool IsCompleted { get; init; }

        public TodoTask(string taskDescription, DateTime dueDate)
        {
            TaskDescription = taskDescription;
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return $"Id: {Id} + Task_Description: {TaskDescription} + Did you do it?: {IsCompleted} + Deadline: {DueDate}";
        }
    }
}




