FROM ubuntu:19.04
MAINTAINER "Antonio Garcia-Dominguez" a.garcia-dominguez@aston.ac.uk
WORKDIR /ttc
COPY . .

# Install base packages required to install TTC2019 language environments
RUN apt-get update && apt-get install -y \
    gnupg ca-certificates apt-transport-https wget

# Install TTC2019 language environments
RUN wget -q https://packages.microsoft.com/config/ubuntu/19.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb && \
    apt-get clean -y && apt-get update -y && \
    apt-get install -y python3 openjdk-11-jdk-headless dotnet-sdk-2.1

# Build all TTC2019 solutions
WORKDIR /ttc
RUN scripts/run.py -b

# Run a Bash shell by default
CMD /bin/bash