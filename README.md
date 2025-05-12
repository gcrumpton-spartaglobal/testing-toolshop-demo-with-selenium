# Testing Toolshop Demo With Selenium

This repo contains a Selenium testing framework for the website https://practicesoftwaretesting.com/.

<br>

# Tech Stack
<p align="center">
  <img src="https://github.com/user-attachments/assets/f0328110-7406-4a08-acc4-ff56f8092d58" height="100" hspace="25">
  <img src="https://github.com/user-attachments/assets/07b1348a-a9a1-4e61-b249-c17ead8fe4a8" height="80" hspace="25">
  <img src="https://github.com/user-attachments/assets/b4210efd-173e-4766-a309-c8e7dd88f095" height="100" hspace="25">
  <img src="https://github.com/user-attachments/assets/dbd7c7af-d708-4a1b-a997-130ad25f9085" height="100" hspace="25">
</p>
<p align="center">
  <img src="https://github.com/user-attachments/assets/eb1f2510-cb34-4173-8084-5a5233dbdb16" height="100" hspace="25">
  <img src="https://github.com/user-attachments/assets/d02dd624-8016-4379-a565-9d0f6d922ddf" height="100" hspace="25">
  <img src="https://github.com/user-attachments/assets/27bd96e7-f389-4c28-86d2-4c3ea81daec1" height="100" hspace="25">
</p>

<br>

# Installation Instructions
## Prerequisites
- Docker
- Visual Studio IDE
  - Ensure you have the plugin 'Reqnroll' installed
- (Optional) Self-hosted runner for running GitHub Actions

## (Optional) Set Up Self-Hosted Runner
In order to run the GitHub workflow, you need to make sure you have a self-hosted runner installed on your machine.
  1. Fork this repo.
  2. Navigate to Settings -> Actions -> Runners
  3. Follow the instructions for setting up self-hosted runners on your machine.

## Install Files and Set Up Project
1. Clone this project, or the fork of this project if you want to run a self-hosted runner.
2. Start Docker Engine e.g. open Docker Desktop.
    - Open Docker terminal and navigate to the project repo.
    - Run the command `docker compose up -d`
3. Check that Selenium Grid is now running by going to localhost:4444 on your web browser. **Note**: if you want to run the GitHub workflow, you'll need to run the command `docker compose down` to stop Selenium Grid first. The workflow will start this container for you, and uses the same ports.
