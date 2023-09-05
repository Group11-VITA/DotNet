﻿namespace DotNetComputerSekho.Models
{
    using Microsoft.CodeAnalysis.Options;
    using System.Collections.Generic;
    

    public interface IBatchRepository
    {
        void SaveBatch(Batch batch);
        List<Batch> GetAllBatches();
        List<Batch> GetBatchByBatchNo(int batchNo);
        List<Batch> GetUpcomingBatches();
        List<Batch> GetCurrentBatches();
        List<Batch> GetPastBatches();
        List<Batch> GetBatchesByBatchName(string batchName);
        List<Batch> GetBatchesByCourseId(int courseId);
    }

}
