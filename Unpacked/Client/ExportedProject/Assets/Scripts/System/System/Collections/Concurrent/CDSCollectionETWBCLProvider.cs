namespace System.Collections.Concurrent;

[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
[Token(Token = "0x20001AF")]
internal sealed class CDSCollectionETWBCLProvider : EventSource
{
	[Token(Token = "0x400069A")]
	public static CDSCollectionETWBCLProvider Log; //Field offset: 0x0

	[Address(RVA = "0x17B1140", Offset = "0x17B0340", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A6D")]
	private static CDSCollectionETWBCLProvider() { }

	[Address(RVA = "0x17B11B0", Offset = "0x17B03B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A6A")]
	private CDSCollectionETWBCLProvider() { }

	[Address(RVA = "0x17B10C0", Offset = "0x17B02C0", Length = "0x3C")]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Event(5, Level = EventLevel::Verbose (5))]
	[Token(Token = "0x6000A6C")]
	public void ConcurrentBag_TryPeekSteals() { }

	[Address(RVA = "0x17B1100", Offset = "0x17B0300", Length = "0x3C")]
	[CalledBy(Type = typeof(ConcurrentBag`1), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Event(4, Level = EventLevel::Verbose (5))]
	[Token(Token = "0x6000A6B")]
	public void ConcurrentBag_TryTakeSteals() { }

}

