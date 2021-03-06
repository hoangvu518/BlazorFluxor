using StateManagementWithFluxor.Models.Todos.Dtos;

namespace StateManagementWithFluxor.Store.Features.Todos.Actions.LoadTodoDetail
{
    public class LoadTodoDetailSuccessAction
    {
        public LoadTodoDetailSuccessAction(TodoDto todo) => 
            Todo = todo;

        public TodoDto Todo { get; }
    }
}
