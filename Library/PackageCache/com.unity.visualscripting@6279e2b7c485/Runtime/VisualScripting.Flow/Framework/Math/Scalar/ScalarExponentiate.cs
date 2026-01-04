nerId uniqueidentifier,
	@lockTimeout int,
	@workflowHostType uniqueidentifier,
	@enqueueCommand bit,
	@deleteInstanceOnCompletion bit,	
	@primitiveLockOwnerData varbinary(max),
	@complexLockOwnerData varbinary(max),
	@writeOnlyPrimitiveLockOwnerData varbinary(max),
	@writeOnlyComplexLockOwnerData varbinary(max),
	@encodingOption tinyint,
	@machineName nvarchar(128),
	@identityMetadata xml = null
as
begin
	set nocount on
	set transaction isolation level read committed
	set xact_abort on;	
	
	begin transaction
	
	declare @lockAcquired bigint
	declare @lockExpiration datetime
	declare @now datetime
	declare @result int
	declare @surrogateLockOwnerId bigint
	declare @workflowIdentityFilter tinyint

	set @result = 0
	
	exec @lockAcquired = sp_getapplock @Resource = 'InstanceStoreLock', @LockMode = 'Shared', @LockTimeout = 10000
		
	if (@lockAcquired < 0)
	begin
		select @result as 'Result'
		set @result = 13
	end
	
	if (@result = 0)
	begin
		-- insert the list of identity to the DefinitionIdentityTable
		exec [System.Activities.DurableInstancing].[InsertDefinitionIdentity] @identityMetadata
		
		if (@identityMetadata is not null)
		 begin
			select @workflowIdentityFilter = T.Item.value('WorkflowIdentityFilter[1]', 'tinyint')
			from @identityMetadata.nodes('/IdentityMetadata'