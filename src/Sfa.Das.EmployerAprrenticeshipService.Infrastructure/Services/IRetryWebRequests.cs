﻿namespace Sfa.Das.EmployerAprrenticeshipService.Infrastructure.Services
{
    using System;
    using System.Threading.Tasks;

    public interface IRetryWebRequests
    {
        Task<T> RetryWeb<T>(Func<Task<T>> action, Action<Exception> onError);

        void RetryWeb(Action action, Action<Exception> onError);
    }
}