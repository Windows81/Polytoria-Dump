namespace Unity.Properties;

[Token(Token = "0x200003C")]
public class KeyValuePairPropertyBag : PropertyBag<KeyValuePair`2<TKey, TValue>>, INamedProperties<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private sealed class <>c
	{
		[Token(Token = "0x400005B")]
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0

		[Address(RVA = "0x7FC070", Offset = "0x7FB270", Length = "0x11F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DF")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E0")]
		public <>c() { }

		[Address(RVA = "0x7FA450", Offset = "0x7F9650", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E1")]
		internal TKey <.cctor>b__7_0(ref KeyValuePair<TKey, TValue>& container) { }

		[Address(RVA = "0x7FA4F0", Offset = "0x7F96F0", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E2")]
		internal TValue <.cctor>b__7_1(ref KeyValuePair<TKey, TValue>& container) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003E")]
	private sealed class <GetPropertiesEnumerable>d__4 : IEnumerable<IProperty`1<KeyValuePair`2<TKey, TValue>>>, IEnumerable, IEnumerator<IProperty`1<KeyValuePair`2<TKey, TValue>>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005C")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005D")]
		private IProperty<KeyValuePair`2<TKey, TValue>> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005E")]
		private int <>l__initialThreadId; //Field offset: 0x0

		[Token(Token = "0x1700002E")]
		private override IProperty<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000E6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700002F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60000E8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E3")]
		public <GetPropertiesEnumerable>d__4(int <>1__state) { }

		[Address(RVA = "0x8124C0", Offset = "0x8116C0", Length = "0x144")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x812610", Offset = "0x811810", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E9")]
		private override IEnumerator<IProperty`1<KeyValuePair`2<TKey, TValue>>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E6")]
		private override IProperty<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.get_Current() { }

		[Address(RVA = "0x812910", Offset = "0x811B10", Length = "0x18")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000EA")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E4")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000059")]
	private static readonly DelegateProperty<KeyValuePair`2<TKey, TValue>, TKey> s_KeyProperty; //Field offset: 0x0
	[Token(Token = "0x400005A")]
	private static readonly DelegateProperty<KeyValuePair`2<TKey, TValue>, TValue> s_ValueProperty; //Field offset: 0x0

	[Address(RVA = "0xCE0040", Offset = "0xCDF240", Length = "0x4B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DE")]
	private static KeyValuePairPropertyBag`2() { }

	[Address(RVA = "0xCE0500", Offset = "0xCDF700", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DD")]
	public KeyValuePairPropertyBag`2() { }

	[Address(RVA = "0xCDFC60", Offset = "0xCDEE60", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Unity.Properties.PropertyCollection`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Unity.Properties.IProperty`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D9")]
	public virtual PropertyCollection<KeyValuePair`2<TKey, TValue>> GetProperties() { }

	[Address(RVA = "0xCDFDA0", Offset = "0xCDEFA0", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Unity.Properties.PropertyCollection`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Unity.Properties.IProperty`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DA")]
	public virtual PropertyCollection<KeyValuePair`2<TKey, TValue>> GetProperties(ref KeyValuePair<TKey, TValue>& container) { }

	[Address(RVA = "0xCDFBB0", Offset = "0xCDEDB0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetPropertiesEnumerable>d__4))]
	[Token(Token = "0x60000DB")]
	private static IEnumerable<IProperty`1<KeyValuePair`2<TKey, TValue>>> GetPropertiesEnumerable() { }

	[Address(RVA = "0xCDFEE0", Offset = "0xCDF0E0", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DC")]
	public override bool TryGetProperty(ref KeyValuePair<TKey, TValue>& container, string name, out IProperty<KeyValuePair`2<TKey, TValue>>& property) { }

}

