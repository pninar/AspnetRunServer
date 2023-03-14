Application project - business logic
- the application project contains the models that are the business layer
representations of the entities.

- these models are stored in the Models folder

- each model class is based on the BaseModel class

- a mapper profile defines the mappings between the entities and the models.
this profile is contained in the Mapper folder

- i don't understand the Lazy property of the mapper class

- the application project contains services stored in the Services folder.

- each service is based on an interface stored in the Interfaces folder

- each service contains the methods necessary to communicate between the business layer and the data layer

- that is why there is no base service - since each service communicates with the data layer in a different way.
some services just get data. some update data. some do both...

- each service corresponds to a repository in the Infrastructure project.
so each service contains a member property corresponding to the repository it needs

- the repositories are injected into the services.

- mapping for dependency injection of the services is done in the "Add Application Layer" section of the
ConfigureAspnetRunServices method of startup.cs

- the application project has its own exception handling. it defines class
ApplicationException stored in the exceptions folder. exceptions encountered by
the services throw this exception
