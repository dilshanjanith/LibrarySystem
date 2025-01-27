using LibrarySystem.Application.Book;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Model.ValitateBooks
{
    public class Book_IdValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var bookId = context.ActionArguments["id"] as int?;

            if (bookId.HasValue)
            {
                if (bookId.Value <= 0)
                {
                    context.ModelState.AddModelError("BookId", "BookId is Invalid!");
                    var validationProblemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status400BadRequest
                    };
                    context.Result = new BadRequestObjectResult(validationProblemDetails);
                }
                else if (!BookReposetory.IsExistBook(bookId.Value))
                {
                    context.ModelState.AddModelError("BookId", "Book does not exist!");
                    var validationProblemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status404NotFound
                    };
                    context.Result = new NotFoundObjectResult(validationProblemDetails);
                }
            }
        }
    }
}
