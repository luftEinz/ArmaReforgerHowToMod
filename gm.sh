#!/bin/bash
commit="Date: $(date +%Y-%m-%d\ %H:%M:%S)"
Site="https://mods.keays.pro/"
project="$(pwd)"
echo "Current directory: $project"
echo "Current date and time: $(date +%Y-%m-%d\ %H:%M:%S)"
echo "Current branch: $(git rev-parse --abbrev-ref HEAD)"
echo "Current status: $(git status)"
echo "$(ls -la)"
git commit -m "$commit\n$Site\n$project"
git push origin main
git diff --cached
echo "Changes have been committed and pushed to the main branch."
echo "Current commit message: $commit"
echo "Current date and time: $(date +%Y-%m-%d %H:%M:%S)"
echo "Current branch: $(git rev-parse --abbrev-ref HEAD)"
echo "Current status:"
git status
echo "Current log:"
git log --oneline -n 5
echo "Current branch: $(git rev-parse --abbrev-ref HEAD)"
echo "Current status:"
