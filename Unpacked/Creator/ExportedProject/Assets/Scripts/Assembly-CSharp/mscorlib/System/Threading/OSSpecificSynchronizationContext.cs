namespace System.Threading;

[Token(Token = "0x2000225")]
internal class OSSpecificSynchronizationContext : SynchronizationContext
{
	[CompilerGenerated]
	[Token(Token = "0x2000228")]
	private sealed class <>c
	{
		[Token(Token = "0x4000A22")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000A23")]
		public static CreateValueCallback<Object, OSSpecificSynchronizationContext> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x151E3F0", Offset = "0x151D5F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600122C")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600122D")]
		public <>c() { }

		[Address(RVA = "0x151E1C0", Offset = "0x151D3C0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600122E")]
		internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

	}

	[Token(Token = "0x2000227")]
	private class InvocationContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A20")]
		private SendOrPostCallback m_Delegate; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A21")]
		private object m_State; //Field offset: 0x18

		[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600122A")]
		public InvocationContext(SendOrPostCallback d, object state) { }

		[Address(RVA = "0x1512E80", Offset = "0x1512080", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600122B")]
		public void Invoke() { }

	}

	[Token(Token = "0x2000226")]
	private sealed class InvocationEntryDelegate : MulticastDelegate
	{

		[Address(RVA = "0x391F20", Offset = "0x391120", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001228")]
		public InvocationEntryDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001229")]
		public override void Invoke(IntPtr arg) { }

	}

	[Token(Token = "0x4000A1F")]
	private static readonly ConditionalWeakTable<Object, OSSpecificSynchronizationContext> s_ContextCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A1E")]
	private object m_OSSynchronizationContext; //Field offset: 0x18

	[Address(RVA = "0x1515F30", Offset = "0x1515130", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001227")]
	private static OSSpecificSynchronizationContext() { }

	[Address(RVA = "0x13847D0", Offset = "0x13839D0", Length = "0x31")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600121F")]
	private OSSpecificSynchronizationContext(object osContext) { }

	[Address(RVA = "0x15159C0", Offset = "0x1514BC0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001221")]
	public virtual SynchronizationContext CreateCopy() { }

	[Address(RVA = "0x1515A40", Offset = "0x1514C40", Length = "0x183")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "System.Runtime.CompilerServices.ConditionalWeakTable`2<TKey, TValue>+CreateValueCallback<TKey, TValue>"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001220")]
	public static OSSpecificSynchronizationContext Get() { }

	[Address(RVA = "0x1515A30", Offset = "0x1514C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6E0")]
	[Token(Token = "0x6001225")]
	private static object GetOSContext() { }

	[Address(RVA = "0x1515BD0", Offset = "0x1514DD0", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Exception), Member = "ReportUnhandledException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(InvocationEntryDelegate))]
	[Token(Token = "0x6001224")]
	private static void InvocationEntry(IntPtr arg) { }

	[Address(RVA = "0x1515D30", Offset = "0x1514F30", Length = "0x1BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D8C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001223")]
	public virtual void Post(SendOrPostCallback d, object state) { }

	[Address(RVA = "0x1515D20", Offset = "0x1514F20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D8C0")]
	[Token(Token = "0x6001226")]
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	[Address(RVA = "0x1515EF0", Offset = "0x15150F0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001222")]
	public virtual void Send(SendOrPostCallback d, object state) { }

}

