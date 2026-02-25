namespace System.Diagnostics.Tracing;

[Token(Token = "0x2000586")]
public class EventSource : IDisposable
{
	[Token(Token = "0x2000587")]
	private struct EventData
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001790")]
		private IntPtr <DataPointer>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001791")]
		private int <Size>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4001792")]
		private int <Reserved>k__BackingField; //Field offset: 0xC

		[Token(Token = "0x17000616")]
		public IntPtr DataPointer
		{
			[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002867")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000618")]
		internal int Reserved
		{
			[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002869")]
			internal set { } //Length: 4
		}

		[Token(Token = "0x17000617")]
		public int Size
		{
			[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
			[CallerCount(Count = 4)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002868")]
			 set { } //Length: 4
		}

		[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002867")]
		public void set_DataPointer(IntPtr value) { }

		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002869")]
		internal void set_Reserved(int value) { }

		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002868")]
		public void set_Size(int value) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400178F")]
	private string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000615")]
	private string Name
	{
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600285B")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x143C230", Offset = "0x143B430", Length = "0x50")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002857")]
	protected EventSource() { }

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002858")]
	public EventSource(string eventSourceName) { }

	[Address(RVA = "0x143E6A0", Offset = "0x143D8A0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002859")]
	internal EventSource(Guid eventSourceGuid, string eventSourceName) { }

	[Address(RVA = "0x143E140", Offset = "0x143D340", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600285E")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600285F")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x12D1B30", Offset = "0x12D0D30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600285A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600285C")]
	public bool IsEnabled() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600285D")]
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600285B")]
	private void set_Name(string value) { }

	[Address(RVA = "0x143E540", Offset = "0x143D740", Length = "0x32")]
	[CalledBy(Type = "System.Collections.Concurrent.CDSCollectionETWBCLProvider", Member = "ConcurrentBag_TryTakeSteals", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Concurrent.CDSCollectionETWBCLProvider", Member = "ConcurrentBag_TryPeekSteals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6002860")]
	protected void WriteEvent(int eventId) { }

	[Address(RVA = "0x143E340", Offset = "0x143D540", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002861")]
	protected void WriteEvent(int eventId, int arg1) { }

	[Address(RVA = "0x143E580", Offset = "0x143D780", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002862")]
	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	[Address(RVA = "0x143E1B0", Offset = "0x143D3B0", Length = "0x186")]
	[CalledBy(Type = typeof(ArrayPoolEventSource), Member = "BufferReturned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002863")]
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002864")]
	protected void WriteEvent(int eventId, Object[] args) { }

	[Address(RVA = "0x143E400", Offset = "0x143D600", Length = "0x136")]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "CriticalFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "ErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetEventSource", Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x6002865")]
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002866")]
	protected void WriteEventCore(int eventId, int eventDataCount, EventData* data) { }

}

