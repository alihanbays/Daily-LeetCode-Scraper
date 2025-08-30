# Daily LeetCode Scraper

## Overview
This project automatically fetches the **LeetCode Daily Challenge** and posts it into a Microsoft Teams channel. Instead of manually checking LeetCode every day, the scraper handles it in the background so the team always has the daily problem ready to discuss.

## Why It Was Created
We started a daily LeetCode group at work with a simple goal:
- Everyone gets the same problem at the start of the day.  
- Each person works on solving it individually.  
- By the end of the day, we regroup and compare solutions.  

To keep this consistent, we needed a bot that could automatically pull the challenge and push it to Teams. This way no one has to remember to share the problem, and we can focus on solving and learning.

## What It Does
- Scrapes the **Daily Challenge** from LeetCode.  
- Formats the problem details.  
- Posts it into a **Microsoft Teams channel** using a webhook.  
- Runs automatically on a schedule so it’s hands-off once set up.  

## Setup Instructions

### 1. Clone the Repository
```bash
git clone https://github.com/alihanbays/Daily-LeetCode-Scraper.git
cd Daily-LeetCode-Scraper
```

### 2. Build the Project
This project is written in **.NET**, so make sure you have the .NET SDK installed. Then build it:
```bash
dotnet build
```

### 3. Configure Teams Webhook
- Go to Microsoft Teams → Connectors → Incoming Webhook.  
- Copy the webhook URL.  
- Add this URL to the project’s configuration file (e.g., `appsettings.json`).  

### 4. Run the Scraper
```bash
dotnet run
```

On execution, the scraper will:
- Fetch the daily challenge from LeetCode.  
- Format the problem details.  
- Post it directly into your Teams channel.  

### 5. Automate It
To make it run every day automatically:
- **Linux/Mac:** Add a cron job.  
- **Windows:** Use Task Scheduler.  

---

## Example Output in Teams
- Problem Title  
- Difficulty (Easy/Medium/Hard)  
- Direct link to the LeetCode problem  

This ensures the team can jump right into the problem without delays.
