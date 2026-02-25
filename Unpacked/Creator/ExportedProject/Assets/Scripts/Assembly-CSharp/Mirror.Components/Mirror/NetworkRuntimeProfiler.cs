namespace Mirror;

[Token(Token = "0x2000045")]
public class NetworkRuntimeProfiler : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private sealed class <>c
	{
		[Token(Token = "0x400019E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400019F")]
		public static Func<Stat, Stat> <>9__18_0; //Field offset: 0x8
		[Token(Token = "0x40001A0")]
		public static Func<Stat, Stat> <>9__18_1; //Field offset: 0x10
		[Token(Token = "0x40001A1")]
		public static Func<Stat, Stat> <>9__18_2; //Field offset: 0x18
		[Token(Token = "0x40001A2")]
		public static Func<Stat, Stat> <>9__18_3; //Field offset: 0x20

		[Address(RVA = "0x12466F0", Offset = "0x12458F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000260")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000261")]
		public <>c() { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000262")]
		internal Stat <Print>b__18_0(Stat stat) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000263")]
		internal Stat <Print>b__18_1(Stat stat) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000264")]
		internal Stat <Print>b__18_2(Stat stat) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000265")]
		internal Stat <Print>b__18_3(Stat stat) { }

	}

	[Token(Token = "0x2000049")]
	private class MessageStats
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000198")]
		public readonly Dictionary<Type, Stat> MessageByType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000199")]
		public readonly Dictionary<UInt16, Stat> RpcByHash; //Field offset: 0x18

		[Address(RVA = "0x122BFD0", Offset = "0x122B1D0", Length = "0xBD")]
		[CalledBy(Type = typeof(NetworkRuntimeProfiler), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600025F")]
		public MessageStats() { }

		[Address(RVA = "0x122BAF0", Offset = "0x122ACF0", Length = "0x273")]
		[CalledBy(Type = typeof(NetworkRuntimeProfiler), Member = "HandleMessageOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRuntimeProfiler), Member = "HandleMessageIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(MessageStats), Member = "RecordRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(MessageInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600025C")]
		public void Record(MessageInfo info) { }

		[Address(RVA = "0x122B8B0", Offset = "0x122AAB0", Length = "0x23D")]
		[CalledBy(Type = typeof(MessageStats), Member = "Record", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RemoteProcedureCalls), Member = "GetDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(RemoteCallDelegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Extensions), Member = "GetMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600025D")]
		private void RecordRpc(ushort hash, MessageInfo info) { }

		[Address(RVA = "0x122BD70", Offset = "0x122AF70", Length = "0x259")]
		[CalledBy(Type = typeof(NetworkRuntimeProfiler), Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 8)]
		[Token(Token = "0x600025E")]
		public void ResetRecent() { }

	}

	[Token(Token = "0x200004A")]
	internal enum OutputType
	{
		UnityLog = 0,
		StdOut = 1,
		File = 2,
	}

	[Token(Token = "0x2000047")]
	internal enum SortBy
	{
		RecentBytes = 0,
		RecentCount = 1,
		TotalBytes = 2,
		TotalCount = 3,
	}

	[Token(Token = "0x2000046")]
	internal class Sorter : IComparer<Stat>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400018D")]
		public SortBy Order; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000258")]
		public Sorter() { }

		[Address(RVA = "0x1245860", Offset = "0x1244A60", Length = "0xCA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000257")]
		public override int Compare(Stat a, Stat b) { }

	}

	[Token(Token = "0x2000048")]
	internal class Stat
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000193")]
		public string Name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000194")]
		public long TotalCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000195")]
		public long TotalBytes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000196")]
		public long RecentCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000197")]
		public long RecentBytes; //Field offset: 0x30

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025B")]
		public Stat() { }

		[Address(RVA = "0x1245930", Offset = "0x1244B30", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600025A")]
		public void Add(int count, int bytes) { }

		[Address(RVA = "0x1245950", Offset = "0x1244B50", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000259")]
		public void ResetRecent() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000185")]
	[Tooltip("How many seconds to accumulate 'recent' stats for, this is also the output interval")]
	public float RecentDuration; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000186")]
	public Sorter Sort; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000187")]
	public OutputType Output; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000188")]
	[Tooltip("If Output is set to 'File', where to the path of that file")]
	public string OutputFilePath; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000189")]
	private readonly MessageStats inStats; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400018A")]
	private readonly MessageStats outStats; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400018B")]
	private readonly StringBuilder printBuilder; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400018C")]
	private float elapsedSinceReset; //Field offset: 0x58

	[Address(RVA = "0x12377B0", Offset = "0x12369B0", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MessageStats), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000256")]
	public NetworkRuntimeProfiler() { }

	[Address(RVA = "0x1234BC0", Offset = "0x1233DC0", Length = "0x1A3")]
	[CalledBy(Type = typeof(NetworkRuntimeProfiler), Member = "Print", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000254")]
	private static string FormatBytes(long bytes) { }

	[Address(RVA = "0x1234D70", Offset = "0x1233F70", Length = "0x193")]
	[CalledBy(Type = typeof(NetworkRuntimeProfiler), Member = "Print", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000255")]
	private string FormatCount(long count) { }

	[Address(RVA = "0x1234F10", Offset = "0x1234110", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageStats), Member = "Record", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000251")]
	private void HandleMessageIn(MessageInfo info) { }

	[Address(RVA = "0x1234F50", Offset = "0x1234150", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageStats), Member = "Record", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MessageInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000250")]
	private void HandleMessageOut(MessageInfo info) { }

	[Address(RVA = "0x1234F90", Offset = "0x1234190", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkRuntimeProfiler), Member = "Print", ReturnType = typeof(void))]
	[Calls(Type = typeof(MessageStats), Member = "ResetRecent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000252")]
	private void LateUpdate() { }

	[Address(RVA = "0x1235000", Offset = "0x1234200", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "remove_InMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "remove_OutMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600024F")]
	private void OnDestroy() { }

	[Address(RVA = "0x12350B0", Offset = "0x12342B0", Length = "0x2648")]
	[CalledBy(Type = typeof(NetworkRuntimeProfiler), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "PadLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(File), Member = "AppendAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "PadLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Console), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NetworkRuntimeProfiler), Member = "FormatCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkRuntimeProfiler), Member = "FormatBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x6000253")]
	private void Print() { }

	[Address(RVA = "0x1237700", Offset = "0x1236900", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "add_InMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "add_OutMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600024E")]
	private void Start() { }

}

