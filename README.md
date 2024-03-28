# Drone Photos

## TODO
- Combine razor & csthml
- Handle Razor posts
  - https://stackify.com/asp-net-razor-pages-vs-mvc/
- Combine razor views with cshtml
  - https://mikaelkoskinen.net/post/combining-razor-blazor-pages-single-asp-net-core-3-application
- Add email to registration
  - https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-8.0
  - https://www.c-sharpcorner.com/article/implement-gmail-and-facebook-based-authentication-in-asp-net-core-2-2/
- Play with JsInterop
  - https://www.yogihosting.com/blazor-js-interop-javascript/
  - https://github.com/google/j2cl/blob/master/docs/jsinterop-by-example.md
  - https://dev.to/rasheedmozaffar/intro-to-js-interop-in-blazor-46mo
  - https://blazor-university.com/javascript-interop/
 - Add user roles
    - https://www.syncfusion.com/faq/blazor/general/how-do-you-implement-role-based-authorization-in-blazor
    - https://stackoverflow.com/questions/63444809/blazor-identity-add-roles-on-application-startup
    - https://auth0.com/blog/role-based-access-control-in-blazor-apps/
    - https://blazorhelpwebsite.com/ViewBlogPost/21
    - https://stackoverflow.com/questions/75586668/how-do-i-use-the-user-roles-from-the-azure-app-service-authentication-feature-in#comment133368280_75586668
- Create an admin login with access to image management
  - https://learn.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal-subscription-admin
  - https://stackoverflow.com/questions/75586668/how-do-i-use-the-user-roles-from-the-azure-app-service-authentication-feature-in
- Create image upload locally
- Create a blob container and a blob (page blobs I think)
  - https://learn.microsoft.com/en-us/azure/event-grid/storage-upload-process-images?tabs=azure-cli 
  - https://learn.microsoft.com/en-us/azure/storage/blobs/blob-upload-function-trigger?tabs=azure-portal
  - https://stackoverflow.com/questions/31531026/saving-images-in-azure-storage
- Allow folders to be created, moved and deleted
- Upload images to selected blob folder 
- Enable images to be moved
- Implement Masonry.js
  - https://masonry.desandro.com/
- Display images
- Put it in Docker 
- Unit tests (include in workflow)
  - NUnit
  - Moq
  - FluentValidation
  - AutoFixture
  - Fakeiteasy
  - NSubstitute
  - Dapper
- Deployment slots
  - Update workflow to switch between deployment slots
- Azure Frontdoor
- MediatR
- SignalR

## Useful Links
- JS Component Library
  - https://ui.shadcn.com/docs/installation/
  - 

## Completed

- Skeleton Site
- Create Github repo and attach it to the site
- Enable CICD using Azure
- Remove Azure/GitHub CICD and create it manually
  - https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=applevel%2Caspnetcore
    - (With some help of copying from Azure created pipelines)
- Upgrade to .NET 8
- Add Blazor's built in authentication
  - https://chrissainty.com/securing-your-blazor-apps-introduction-to-authentication-with-blazor/

## Markdown Cheatsheets
https://www.markdownguide.org/basic-syntax/#ordered-lists  
https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet  
https://github.com/tchapi/markdown-cheatsheet/blob/master/README.md


## Purpose of this app
Upload and display drone photos