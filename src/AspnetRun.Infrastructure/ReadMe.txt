Infrastructure project - data layer

- data contexts are stored in the Data folder

- data contexts are loaded in the startup.cs program of the web application:
ConfigureDatabases

- need to load the necessary dependencies to work with the specific contexts

- connection strings are stored in teh appsettings.json file of the web application

- the infrastructure project has its own exception handling. it defines class
InfrastructureException stored in the exceptions folder. exceptions encountered by
the repositories throw this exception - but i don't see it being used

- the repositories are stored in the Repositories folder.

- all repositories are based on the generic repository, class Repository<T>. this class is based on
IRepository<T> which is in the core project and expects that every item <T> be based 
on the Entity class which is also in the core project

- class Repository<T> contains all the base crud methods

- all repositories are also based on a specific repository. so, for example,
 CategoryRepository will be based on Repository<Category> AND ICategoryRepository
 the specific repository will contain the logic specific for that entity

 - the specific repositories contain the calls with specifications to the database. 
 these are the calls that require includes, where.... and are therefore specific to the item

 - the specifications that are used by the specific repositores are contained in the core project

 - question, we have:
 public class CategoryRepository : Repository<Category>, ICategoryRepository
 public interface ICategoryRepository : IRepository<Category>
 public class Repository<T> : IRepository<T> where T : Entity

 so, we have two basings on IRepository. i tried to remove one and got and error so both are necessary

 - question - i see the logging being used.


