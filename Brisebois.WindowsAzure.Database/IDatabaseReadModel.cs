﻿using System;
using System.Threading.Tasks;

namespace Brisebois.WindowsAzure.Database
{
    public interface IDatabaseReadModel<out TModel>
    {
        Task<TResult> QueryAsync<TResult>(Func<TModel, TResult> query);
        Task<TResult> QueryAsync<TResult>(Func<TModel, TResult> query,
                                          RetryParams retryParams);
    }
}