/*
 * User API
 *
 * A simple API to manage users
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using UsersApi.Attributes;
using UsersApi.Models;

namespace UsersApi.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class UserApiController : ControllerBase
    { 
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <remarks>Creates a new user</remarks>
        /// <param name="createUserRequest">User to create</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="201">User created</response>
        [HttpPost]
        [Route("/user")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("CreateUser")]
        [SwaggerResponse(statusCode: 201, type: typeof(User), description: "User created")]
        public virtual async Task<IActionResult> CreateUser([FromBody]CreateUserRequest createUserRequest, CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(User));
            string exampleJson = null;
            exampleJson = "{\r\n  \"phone\" : \"phone\",\r\n  \"name\" : \"name\",\r\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\r\n  \"email\" : \"email\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<User>(exampleJson)
            : default(User);
            //TODO: Change the data returned
            return await Task.FromResult<IActionResult>(new ObjectResult(example));
        }

        /// <summary>
        /// Delete a user by id
        /// </summary>
        /// <remarks>Deletes a user by id</remarks>
        /// <param name="id">The user id</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="204">User deleted successfully</response>
        [HttpDelete]
        [Route("/user/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteUserById")]
        public virtual async Task<IActionResult> DeleteUserById([FromRoute (Name = "id")][Required]Guid id, CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a user by id
        /// </summary>
        /// <remarks>Returns a user by id</remarks>
        /// <param name="id">The user id</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="200">A user</response>
        [HttpGet]
        [Route("/user/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetUserById")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "A user")]
        public virtual async Task<IActionResult> GetUserById([FromRoute (Name = "id")][Required]Guid id, CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(User));
            string exampleJson = null;
            exampleJson = "{\r\n  \"phone\" : \"phone\",\r\n  \"name\" : \"name\",\r\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\r\n  \"email\" : \"email\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<User>(exampleJson)
            : default(User);
            //TODO: Change the data returned
            return await Task.FromResult<IActionResult>(new ObjectResult(example));
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <remarks>Returns all users</remarks>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="200">A list of users</response>
        [HttpGet]
        [Route("/users")]
        [ValidateModelState]
        [SwaggerOperation("GetUsers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<User>), description: "A list of users")]
        public virtual async Task<IActionResult> GetUsers(CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<User>));
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"phone\" : \"phone\",\r\n  \"name\" : \"name\",\r\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\r\n  \"email\" : \"email\"\r\n}, {\r\n  \"phone\" : \"phone\",\r\n  \"name\" : \"name\",\r\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\r\n  \"email\" : \"email\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<User>>(exampleJson)
            : default(List<User>);
            //TODO: Change the data returned
            return await Task.FromResult<IActionResult>(new ObjectResult(example));
        }

        /// <summary>
        /// Update a user by id
        /// </summary>
        /// <remarks>Updates a user by id</remarks>
        /// <param name="id">The user id</param>
        /// <param name="user">User to update</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="200">User updated</response>
        [HttpPut]
        [Route("/user/{id}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("UpdateUserById")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "User updated")]
        public virtual async Task<IActionResult> UpdateUserById([FromRoute (Name = "id")][Required]Guid id, [FromBody]User user, CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(User));
            string exampleJson = null;
            exampleJson = "{\r\n  \"phone\" : \"phone\",\r\n  \"name\" : \"name\",\r\n  \"id\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\r\n  \"email\" : \"email\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<User>(exampleJson)
            : default(User);
            //TODO: Change the data returned
            return await Task.FromResult<IActionResult>(new ObjectResult(example));
        }
    }
}
