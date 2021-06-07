---
title: Someone just pushed
labels: bug
---
Someone just pushed, oh no! Here's who did it: {{ payload.sender.login }}.

#{{ pullRequest.pull_number }}

tools.context.pullRequest.pull_number :{{ tools.context.pullRequest.pull_number }}

tools.context.pullRequest :{{ tools.context.pullRequest }}

payload: {{ payload }}

sha: {{ sha }}
