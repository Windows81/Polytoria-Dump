namespace System.Collections.Concurrent;

[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
[Token(Token = "0x20005C1")]
internal sealed class CDSCollectionETWBCLProvider : EventSource
{
	[Token(Token = "0x400181D")]
	public static CDSCollectionETWBCLProvider Log; //Field offset: 0x0

	[Address(RVA = "0x143C180", Offset = "0x143B380", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A0C")]
	private static CDSCollectionETWBCLProvider() { }

	[Address(RVA = "0x143C230", Offset = "0x143B430", Length = "0x50")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A0A")]
	private CDSCollectionETWBCLProvider() { }

	[Address(RVA = "0x40DBA0", Offset = "0x40CDA0", Length = "0x3")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Event(3, Level = EventLevel::Warning (3))]
	[Token(Token = "0x6002A0B")]
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

}

