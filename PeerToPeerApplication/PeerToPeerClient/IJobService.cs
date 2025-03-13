using System;

namespace PeerToPeerClient
{
    public interface IJobService
    {
        bool HasPendingJob();

        (string EncodedJobCode, string Hash) GetPendingJob();

        void SubmitJob(string encodedJobCode, string hash);

        void ReceiveJobResult(string result);
    }
}
