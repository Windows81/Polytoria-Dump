namespace Unity.IO.LowLevel.Unsafe;

[NativeAsStruct]
[NativeConditional("ENABLE_PROFILER")]
[RequiredByNativeCode]
[Token(Token = "0x200002F")]
public class AsyncReadManagerMetricsFilters
{
	[FieldOffset(Offset = "0x10")]
	[NativeName("typeIDs")]
	[Token(Token = "0x4000090")]
	internal UInt64[] TypeIDs; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("states")]
	[Token(Token = "0x4000091")]
	internal ProcessingState[] States; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[NativeName("readTypes")]
	[Token(Token = "0x4000092")]
	internal FileReadType[] ReadTypes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[NativeName("priorityLevels")]
	[Token(Token = "0x4000093")]
	internal Priority[] PriorityLevels; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[NativeName("subsystems")]
	[Token(Token = "0x4000094")]
	internal AssetLoadingSubsystem[] Subsystems; //Field offset: 0x30

}

