namespace System.Threading.Tasks;

[FriendAccessAllowed]
[Token(Token = "0x2000287")]
internal static class AsyncCausalityTracer
{

	[FriendAccessAllowed]
	[Token(Token = "0x17000203")]
	internal static bool LoggingOn
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[FriendAccessAllowed]
		[Token(Token = "0x6001490")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[FriendAccessAllowed]
	[Token(Token = "0x6001490")]
	internal static bool get_LoggingOn() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[FriendAccessAllowed]
	[Token(Token = "0x6001492")]
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[FriendAccessAllowed]
	[Token(Token = "0x6001491")]
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001494")]
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001493")]
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

}

