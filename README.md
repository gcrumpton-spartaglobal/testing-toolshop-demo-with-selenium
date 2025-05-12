# Testing Toolshop Demo With Selenium
This repo contains a Selenium testing framework for the website https://practicesoftwaretesting.com/.

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
