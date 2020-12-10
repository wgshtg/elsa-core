﻿using System.Threading.Tasks;
using Elsa.Client;
using Elsa.Client.Models;
using ElsaDashboard.Shared.Rpc;
using ProtoBuf.Grpc;

namespace ElsaDashboard.Backend.Rpc
{
    public class WorkflowInstanceService : IWorkflowInstanceService
    {
        private readonly IElsaClient _elsaClient;
        public WorkflowInstanceService(IElsaClient elsaClient) => _elsaClient = elsaClient;
        public Task<PagedList<WorkflowInstance>> ListAsync(int page = 0, int pageSize = 50, CallContext context = default) => _elsaClient.WorkflowInstanceses.ListAsync(page, pageSize, context.CancellationToken);
        public Task<WorkflowInstance?> GetById(string id, CallContext context = default) => _elsaClient.WorkflowInstanceses.GetByIdAsync(id, context.CancellationToken);
    }
}