using System;
using static DevOps.VersionControl.Functions.RunGitPushCommand.GitPushCommandRunner;
using static DevOps.VersionControl.Functions.RunGitRemoteCommand.GitRemoteCommandRunner;

namespace DevOps.VersionControl.Functions.AddOriginGitRemoteAndPush
{
    public static class RemoteAdderAndChangePusher
    {
        private const string add = nameof(add);
        private const string master = nameof(master);
        private const string origin = nameof(origin);

        public static void AddRemoteAndPush(string repositoryDirectory, Uri remoteUri, string branchName = master, string remoteName = origin)
        {
            Remote(repositoryDirectory,
                add,
                remoteName,
                remoteUri.ToString());
            Push(repositoryDirectory,
                remoteName,
                branchName);
        }
    }
}
