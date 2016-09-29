# SCM

Our software configuration management setup attempts to be simple, while giving us power to examine three different facets of our dev process:

1. Status. Tracking how much work is left and how much is completed.
2. Integrity. Understanding how changes affect the application and knowing that the application works as expected.
3. Modifiability. Managing the codebase in such a way as to support additions to the application gracefully without requiring sweeping changes to the application structure.

We use several tools to help us with the above goals:

- Trello, our primary Status tool. Used to track and manage the development of application features. Integrates with Github, so finding the specific pieces of code for a task are easy. All features start here. 
- Github, our primary Modifiability tool. Used to track changes to the codebase. Additionally is an online store for the code so that it can be accessed from anywhere. All features are created here.
- Appveyor, our primary Integrity tool. Used to continously integrate changes in the code. This helps ensure that we are producing working versions of the application. Additionally integrates with Github and Trello to provide "health" style reports on build status.

All of these tools are free for us to use. Additionally, we're providing documentation on our usage of Trello and Appveyor so future teams will be able to get started quickly.

We are also providing documentation below on how we use Git and Github to manage changes to the codebase and help prevent conflicts during development.

## Github

For this application, we try to split our work into pieces that can be worked on separately from other people.
This means trying to structure the code such that changes to separate pieces don't conflict with each other.

For example, changing the `Student` model does not cause conflicts with a change to the `Course` class.
We can achieve this by storing each class in a different file. This way, only changes to the same class can cause conflicts.

Additionally, we can keep work for each individual feature on its own branch. This will help with productivity, as someone working on the `feature1` branch doesn't need to worry about stuff being done to the `feature2` branch.

Furthermore, we can try to keep our branching model as simple as possible by only creating branches from the `master` branch, and only merging back into `master`.
This will help with managing changes that are local to a specific branch. For example, merging the `feature1` branch back into `master` should mean that `feature1` is now being integrated into the production application. By making sure we don't merge `feature2` into `feature1`, we are able to ensure that only `feature1` is added to `master`.

Speaking of `master` and production, the `master` branch is our mainline. This means that it contains work towards the next release version. Most actual work, however, is not commited directly to the `master` branch. Instead, "shallow" feature/bug branches are created to facilitate most code changes. This helps us keep changes for different features separate, while allowing us to still avoid most merge conflicts.

A "shallow" branch is just a branch that is based on the `master` branch and will only merge back into `master`. This way, big waterfalls of branches on branches on branches are avoided, and the actual work is easy to see and understand.

Once a feature/bug branch is ready to be merged back into `master`, we [create a pull request](https://help.github.com/articles/creating-a-pull-request/) in Github for it. This allows Appveyor and Github to check the merge and see if there are any issues with it.
Most of the time there won't be any issues, but sometimes the build might be broken. In this scenario, Appveyor will mark the pull request with a red X mark and will warn about merging. In this scenario, someone should probably make a fix to the branch so that the build passes. If the build passes, then the branch is ok to merge in.