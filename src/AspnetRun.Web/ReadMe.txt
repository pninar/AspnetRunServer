Web project - view
- razor pages (views) are stored in the Pages folder. these will correspond to the angular page components

- each page has an associated service which is contained in the Services folder.

- each service has an associated service interface which is contained
in the Interfaces folder

- each service acts like a unit of work - it contains an application service
for each item that it will need.
for example, the product page needs products and categories, so the 
productPageService contains members for ProductService AND CateogryService
because of this, there is SOME duplicated code. both IProductPageService and ICategoryPageService
contain methods for GetCategories:

Task<IEnumerable<CategoryViewModel>> GetCategories();

and their implementations are the same in the instances of the page serivces:

public async Task<IEnumerable<CategoryViewModel>> GetCategories()
        {
            var list = await _categoryAppService.GetCategoryList();
            var mapped = _mapper.Map<IEnumerable<CategoryViewModel>>(list);
            return mapped;
        }

- the service is injected into the page using dependency injection. 

- mapping for dependency injection of the page services is done in the "Add Web Layer" section of the
ConfigureAspnetRunServices method of startup.cs

- if using angular, we will need a controller for every razor page.

- the controllers are stored in the Controllers folder.

- the controllers have the page service injected into it and calls the page service methods same way as the razor
page would

- the web applications uses viewModels stored in the ViewModels folder. 

- each viewModel is based on the BaseViewModel class

- pages, page serivces and controllers all use viewModels. 

- as mentioned above, the pages serivces use application services. the application
services use Models. so the Web application has a mapper profile to map
between the models and viewModels. this is stored in the Mapper folder of the web application

- similarly, the application project contains a mapper profile to map each model to
its associated entity. 

- right now, i see that the properties of the models and the viewModels are exactly
the same to the mapping between them if very simple. 

- QUESTION - is the mapping between the model and the viewModel going to always be simple like in this example?

- the web project contains two additional folders - Extensions and Healthchecks.
these are not currently used. 
