# Fortune Teller Application
DevOps Practical Project

## Table of Contents
- [Project Overview](#project-overview)
- [Project Management](#project-management)
  * [Trello Board](#trello-board)
  * [Risk Assessment Matrix](#risk-assessment-matrix)
  * [Project Timeline](#project-timeline)
- [Development of Services](#development-of-services)
- [Testing](#testing)
- [Deployment and Automation](#deployment-and-automation)
- [Further Analysis](#further-analysis)
- [Licensing and Copyright](#licensing-and-copyright)
 - [Contributors](#contributors)
 - [Acknowledgements](#acknowledgements)

## Project Overview
The purpose of this project is to create a fortune teller with a service-orientated architecture, composed of four services working together by using appropriate tools, technologies and methodologies. This project is inclusive of effective project management practices, utilising C# and ASP.net for full-stack development, testing functions and use GitHub Actions for creating a pipeline to be able to deploy the application to an app service.

## Project Management
This section will discuss the timeline, trello board, tasks and risks for the project.

###  Trello Board
<img width="957" alt="Capture" src="https://user-images.githubusercontent.com/82107035/122688960-637ab900-d217-11eb-8f17-c5c92b670d65.PNG">

Every use case is inclusive of generating random objects to return it to the user.

### Risk Assessment Matrix
<img width="482" alt="risks" src="https://user-images.githubusercontent.com/82107035/121039125-baf53f80-c7a8-11eb-8956-c4f01c3f8494.PNG">

###  Project Timeline
<img width="543" alt="project plan" src="https://user-images.githubusercontent.com/82107035/121048908-25a97980-c7af-11eb-841e-26a31affe263.PNG">




## Development of Services
The development of the application was done using C# for the backened and ASP.Net for the frontend. Below are screenshots of the final application.

Service 1 - Front-end Service

<img width="300" alt="html" src="https://user-images.githubusercontent.com/82107035/122752000-5944d300-d288-11eb-9ec5-a8e0af991054.PNG">

Service 2 - Randomised number
Generates a random lucky number between 1-100.

<img width="300" alt="luckynumber" src="https://user-images.githubusercontent.com/82107035/122752798-48489180-d289-11eb-9e30-5797973a9ee4.PNG">

Service 3 - Randomised fortune
Generates a random fortune from an array.

<img width="300" alt="fortune" src="https://user-images.githubusercontent.com/82107035/122752804-4bdc1880-d289-11eb-8670-20e96471eb93.PNG">

Service 4 - Merged Service
This service is the most important service as it enables the HTML to interact with the application and communicate with services 2 and 3.

<img width="300" alt="merge" src="https://user-images.githubusercontent.com/82107035/122752816-50a0cc80-d289-11eb-88f1-c2b20093b974.PNG">


## Testing

Testing Analysis: I tested each controller (fortune, luckynumber and merge) which has proved these services work, connect with one another and the app service and it has taught me different ways to solve problems.

<img width="238" alt="tests" src="https://user-images.githubusercontent.com/82107035/123168640-2826f700-d470-11eb-878c-6f9cb0012d6a.PNG">

Test Report

![testreports](https://user-images.githubusercontent.com/82107035/123155818-792eef00-d460-11eb-9cf3-b5be5ca419d4.png)




## Deployment and Automation
Moving to the cloud has a variety of benefits. It is flexible, scalable, secure and disaster recovery will keep information safe - saving time and money. 
QA has provided me with a solid foundation about cloud, deployment and automation and using tools such as Ansible, Terraform, Windows, Linux and Azure's core services to support these processes.

4 different App Services Created in Azure.

<img width="858" alt="app services" src="https://user-images.githubusercontent.com/82107035/123169211-e21e6300-d470-11eb-814e-54d2761b62da.PNG">

I used GitHub Actions to deploy my webapp - this is a workflow automation tool which has CI/CD built into it. This means the the github user can trigger a workflow run if there's a new commit, branch or pull request.

<img width="519" alt="fortunedeployment" src="https://user-images.githubusercontent.com/82107035/123155923-982d8100-d460-11eb-8b3a-c901c8d11bc8.PNG">

<img width="622" alt="deployment" src="https://user-images.githubusercontent.com/82107035/123155906-906ddc80-d460-11eb-9450-d9b5b547ef4f.PNG">


## Further Analysis
Overall Risk Analysis: From revisting the risk analysis,
 
Known Issues: 

Future Implementations: Database - user information,
Testing

## Licensing and Copyright
© Ezra Turner, QA Limited, Avanade

## Contributors
- Ezra Turner <ezra.turner@avanade.com>

## Acknowledgements
- Dara Oladapo
- Victoria Sacre
- Nick Pribyl
- Ben Hesketh
