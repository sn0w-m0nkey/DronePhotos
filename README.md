# Drone Photos

## TODO
- Create local authentication and authorisation
  - Using Blazor's built in authentication - (Looks easiest)
    - https://chrissainty.com/securing-your-blazor-apps-introduction-to-authentication-with-blazor/
  - Scaffold Identity into a Razor project without existing authorization
    - https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-8.0&tabs=visual-studio#scaffold-identity-into-a-blazor-server-project
  - Auth0 Authentication for Blazor Web Apps (specifically for .NET 8)
    - https://auth0.com/blog/auth0-authentication-blazor-web-apps/
    - https://auth0.com/

  - Using user roles
    - https://www.syncfusion.com/faq/blazor/general/how-do-you-implement-role-based-authorization-in-blazor
    - https://stackoverflow.com/questions/63444809/blazor-identity-add-roles-on-application-startup
    - https://auth0.com/blog/role-based-access-control-in-blazor-apps/
    - https://blazorhelpwebsite.com/ViewBlogPost/21
    - https://stackoverflow.com/questions/75586668/how-do-i-use-the-user-roles-from-the-azure-app-service-authentication-feature-in#comment133368280_75586668

  - Helpful page styling
    - https://learn.microsoft.com/en-us/aspnet/core/blazor/security/?view=aspnetcore-8.0
    - https://learn.microsoft.com/en-us/aspnet/core/blazor/security/server/?view=aspnetcore-8.0&tabs=visual-studio

  - Register an application with the Microsoft identity platform - Can't access MS Entra
    - https://learn.microsoft.com/en-us/entra/identity-platform/tutorial-blazor-server
    - https://learn.microsoft.com/en-us/entra/identity-platform/tutorial-web-app-dotnet-register-app
    - https://learn.microsoft.com/en-us/azure/app-service/configure-authentication-provider-aad?tabs=workforce-tenant
    - https://learn.microsoft.com/en-us/azure/app-service/configure-authentication-provider-aad?tabs=workforce-tenant#--option-1-create-a-new-app-registration-automatically

- Create an admin login with access to image management
  - https://learn.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal-subscription-admin
  - https://stackoverflow.com/questions/75586668/how-do-i-use-the-user-roles-from-the-azure-app-service-authentication-feature-in

- Create local folder and image management
- Create a blob container and a blob (page blobs I think)
  - https://learn.microsoft.com/en-us/azure/event-grid/storage-upload-process-images?tabs=azure-cli 
  - https://learn.microsoft.com/en-us/azure/storage/blobs/blob-upload-function-trigger?tabs=azure-portal
  - https://stackoverflow.com/questions/31531026/saving-images-in-azure-storage
- Allow folders to be created, moved and deleted
- Upload images to selected blob folder 
- Enable images to be moved
- Implement Masonry.js (already in solution)
- Display images
- Github doesnt seem to like me experimenting with my env variables, maybe I need them in Azure, not sure yet, well down the list to research
- Put it in Docker 
- Unit tests (include in workflow)

## Useful Links
- JS Component Library
  - https://ui.shadcn.com/docs/installation/
  - https://masonry.desandro.com/

## Completed

- Skeleton Site
- Create Github repo and attach it to the site
- Enable CICD using Azure
- Remove Azure CICD and create it manually
  - https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=applevel%2Caspnetcore
    - (With some help of copying from Azure created pipelines)
- Upgrade to .NET 8

## Markdown Cheatsheets
https://www.markdownguide.org/basic-syntax/#ordered-lists  
https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet  
https://github.com/tchapi/markdown-cheatsheet/blob/master/README.md


## Purpose of this app
... no idea yet