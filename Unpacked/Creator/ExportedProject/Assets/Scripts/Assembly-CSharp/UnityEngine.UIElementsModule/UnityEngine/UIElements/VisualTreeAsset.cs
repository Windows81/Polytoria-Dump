namespace UnityEngine.UIElements;

[HelpURL("UIE-VisualTree-landing")]
[Token(Token = "0x20004F1")]
public class VisualTreeAsset : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x20004F8")]
	private sealed class <>c__DisplayClass76_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400105A")]
		public VisualElementAsset childVea; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024AE")]
		public <>c__DisplayClass76_0() { }

		[Address(RVA = "0x1B67A50", Offset = "0x1B66C50", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60024AF")]
		internal bool <CloneSetupRecursively>b__0(SlotUsageEntry u) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20004F9")]
	private struct <>c__DisplayClass82_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400105B")]
		public VisualElementAsset asset; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20004FA")]
	private sealed class <get_stylesheets>d__31 : IEnumerable<StyleSheet>, IEnumerable, IEnumerator<StyleSheet>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400105C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400105D")]
		private StyleSheet <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400105E")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400105F")]
		public VisualTreeAsset <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001060")]
		private HashSet<StyleSheet> <sent>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001061")]
		private Enumerator<VisualElementAsset> <>s__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001062")]
		private VisualElementAsset <vea>5__3; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4001063")]
		private Enumerator<StyleSheet> <>s__4; //Field offset: 0x58
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4001064")]
		private StyleSheet <stylesheet>5__5; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001065")]
		private Enumerator<String> <>s__6; //Field offset: 0x78
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4001066")]
		private string <stylesheetPath>5__7; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4001067")]
		private StyleSheet <stylesheet>5__8; //Field offset: 0x98

		[Token(Token = "0x1700099B")]
		private override StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60024B6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700099C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60024B8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B0")]
		public <get_stylesheets>d__31(int <>1__state) { }

		[Address(RVA = "0x1B68720", Offset = "0x1B67920", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60024B3")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1B68770", Offset = "0x1B67970", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60024B4")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x1B687C0", Offset = "0x1B679C0", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60024B5")]
		private void <>m__Finally3() { }

		[Address(RVA = "0x1B67CB0", Offset = "0x1B66EB0", Length = "0x7FA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElementAsset), Member = "get_stylesheets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet>))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Panel), Member = "LoadResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(float)}, ReturnType = typeof(Object))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElementAsset), Member = "get_stylesheetPaths", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
		[Calls(Type = typeof(VisualElementAsset), Member = "get_hasStylesheetPaths", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElementAsset), Member = "get_hasStylesheets", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C330")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x60024B2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1B684B0", Offset = "0x1B676B0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B9")]
		private override IEnumerator<StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B6")]
		private override StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current() { }

		[Address(RVA = "0x1B684B0", Offset = "0x1B676B0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024BA")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1B68550", Offset = "0x1B67750", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60024B7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1B68590", Offset = "0x1B67790", Length = "0x18E")]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C340")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C230")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C2E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[Token(Token = "0x60024B1")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20004FB")]
	private sealed class <get_templateDependencies>d__27 : IEnumerable<VisualTreeAsset>, IEnumerable, IEnumerator<VisualTreeAsset>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001068")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001069")]
		private VisualTreeAsset <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400106A")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400106B")]
		public VisualTreeAsset <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400106C")]
		private HashSet<VisualTreeAsset> <sent>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400106D")]
		private Enumerator<UsingEntry> <>s__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400106E")]
		private UsingEntry <entry>5__3; //Field offset: 0x60
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400106F")]
		private VisualTreeAsset <vta>5__4; //Field offset: 0x78

		[Token(Token = "0x1700099D")]
		private override VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60024BF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700099E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60024C1")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024BB")]
		public <get_templateDependencies>d__27(int <>1__state) { }

		[Address(RVA = "0x1B68FA0", Offset = "0x1B681A0", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60024BE")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1B68810", Offset = "0x1B67A10", Length = "0x612")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Panel), Member = "LoadResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(float)}, ReturnType = typeof(Object))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C280")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60024BD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1B68E30", Offset = "0x1B68030", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024C2")]
		private override IEnumerator<VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024BF")]
		private override VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current() { }

		[Address(RVA = "0x1B68E30", Offset = "0x1B68030", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024C3")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60024C1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1B68ED0", Offset = "0x1B680D0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60024C0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1B68F10", Offset = "0x1B68110", Length = "0x85")]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C290")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x60024BC")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20004F7")]
	private struct AssetEntry
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4001055")]
		private string m_Path; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4001056")]
		private string m_TypeFullName; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4001057")]
		private LazyLoadReference<Object> m_AssetReference; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Token(Token = "0x4001058")]
		private int m_InstanceID; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001059")]
		private Type m_CachedType; //Field offset: 0x18

		[Token(Token = "0x1700099A")]
		public object asset
		{
			[Address(RVA = "0x1B5DAA0", Offset = "0x1B5CCA0", Length = "0x63")]
			[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(LazyLoadReference`1), Member = "get_asset", ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60024AC")]
			 get { } //Length: 99
		}

		[Token(Token = "0x17000999")]
		public string path
		{
			[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
			[CallerCount(Count = 140)]
			[DeduplicatedMethod]
			[Token(Token = "0x60024AB")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000998")]
		public Type type
		{
			[Address(RVA = "0x1B5DB10", Offset = "0x1B5CD10", Length = "0x8E")]
			[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssetEntryExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
			[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetAssetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE620")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x60024AA")]
			 get { } //Length: 142
		}

		[Address(RVA = "0x1B5D9D0", Offset = "0x1B5CBD0", Length = "0xC7")]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "RegisterAssetEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LazyLoadReference`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.LazyLoadReference`1<T>")]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60024AD")]
		public AssetEntry(string path, Type type, object asset) { }

		[Address(RVA = "0x1B5DAA0", Offset = "0x1B5CCA0", Length = "0x63")]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(LazyLoadReference`1), Member = "get_asset", ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60024AC")]
		public object get_asset() { }

		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024AB")]
		public string get_path() { }

		[Address(RVA = "0x1B5DB10", Offset = "0x1B5CD10", Length = "0x8E")]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "AssetEntryExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetAssetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE620")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60024AA")]
		public Type get_type() { }

	}

	[Token(Token = "0x20004F4")]
	public struct SlotDefinition
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x400104F")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4001050")]
		public int insertionPointId; //Field offset: 0x8

	}

	[Token(Token = "0x20004F5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct SlotUsageEntry
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4001051")]
		public string slotName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4001052")]
		public int assetId; //Field offset: 0x8

	}

	[Token(Token = "0x20004F2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct UsingEntry
	{
		[Token(Token = "0x400104B")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal static readonly IComparer<UsingEntry> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x400104C")]
		public string alias; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x400104D")]
		public string path; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x400104E")]
		public VisualTreeAsset asset; //Field offset: 0x10

		[Address(RVA = "0x1B6FC50", Offset = "0x1B6EE50", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60024A4")]
		private static UsingEntry() { }

		[Address(RVA = "0x1B6FCD0", Offset = "0x1B6EED0", Length = "0x45")]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "TryGetUsingEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UsingEntry&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "ResolveTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(VisualTreeAsset))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60024A3")]
		public UsingEntry(string alias, string path) { }

	}

	[Token(Token = "0x20004F3")]
	private class UsingEntryComparer : IComparer<UsingEntry>
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024A6")]
		public UsingEntryComparer() { }

		[Address(RVA = "0x1B6FC20", Offset = "0x1B6EE20", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Token(Token = "0x60024A5")]
		public override int Compare(UsingEntry x, UsingEntry y) { }

	}

	[Token(Token = "0x20004F6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	public struct UxmlObjectEntry
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4001053")]
		public int parentId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4001054")]
		public List<UxmlObjectAsset> uxmlObjectAssets; //Field offset: 0x8

		[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60024A7")]
		public UxmlObjectEntry(int parentId, List<UxmlObjectAsset> uxmlObjectAssets) { }

		[Address(RVA = "0x1B70D40", Offset = "0x1B6FF40", Length = "0x13B")]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "AddUxmlObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(string), typeof(UxmlNamespaceDefinition)}, ReturnType = typeof(UxmlObjectAsset))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "CollectUxmlObjectAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UxmlObjectAsset>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "SetUxmlObjectAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UxmlObjectAsset>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x60024A8")]
		public UxmlObjectAsset GetField(string fieldName) { }

		[Address(RVA = "0x1B70E80", Offset = "0x1B70080", Length = "0xC9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Token(Token = "0x60024A9")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x400103A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static string LinkedVEAInTemplatePropertyName; //Field offset: 0x0
	[Token(Token = "0x400103B")]
	internal static string NoRegisteredFactoryErrorMessage; //Field offset: 0x8
	[Token(Token = "0x400103F")]
	private static readonly Dictionary<String, VisualElement> s_TemporarySlotInsertionPoints; //Field offset: 0x10
	[Token(Token = "0x4001040")]
	private static readonly List<Int32> s_VeaIdsPath; //Field offset: 0x18
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400103C")]
	private bool m_ImportedWithErrors; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Token(Token = "0x400103D")]
	private bool m_HasUpdatedUrls; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[SerializeField]
	[Token(Token = "0x400103E")]
	private bool m_ImportedWithWarnings; //Field offset: 0x1A
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4001041")]
	private List<UsingEntry> m_Usings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4001042")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleSheet inlineSheet; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4001043")]
	internal List<VisualElementAsset> m_VisualElementAssets; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4001044")]
	internal List<TemplateAsset> m_TemplateAssets; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4001045")]
	private List<UxmlObjectEntry> m_UxmlObjectEntries; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4001046")]
	private List<Int32> m_UxmlObjectIds; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4001047")]
	private List<AssetEntry> m_AssetEntries; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4001048")]
	private List<SlotDefinition> m_Slots; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4001049")]
	private int m_ContentContainerId; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400104A")]
	private int m_ContentHash; //Field offset: 0x64

	[Token(Token = "0x17000996")]
	internal int contentContainerId
	{
		[Address(RVA = "0x1B04A80", Offset = "0x1B03C80", Length = "0x6")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		[Token(Token = "0x600248C")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 6
		[Address(RVA = "0x5ECD90", Offset = "0x5EBF90", Length = "0x4")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600248D")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000997")]
	public int contentHash
	{
		[Address(RVA = "0x1B5C110", Offset = "0x1B5B310", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600249E")]
		 get { } //Length: 6
		[Address(RVA = "0x19DF2B0", Offset = "0x19DE4B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600249F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700098B")]
	public internal bool importedWithErrors
	{
		[Address(RVA = "0x1A76600", Offset = "0x1A75800", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600246C")]
		 get { } //Length: 7
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600246D")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700098D")]
	public internal bool importedWithWarnings
	{
		[Address(RVA = "0x1B5C120", Offset = "0x1B5B320", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002470")]
		 get { } //Length: 7
		[Address(RVA = "0x5611C0", Offset = "0x5603C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002471")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700098C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool importerWithUpdatedUrls
	{
		[Address(RVA = "0x1B2CF60", Offset = "0x1B2C160", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600246E")]
		internal get { } //Length: 7
		[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600246F")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000995")]
	internal List<SlotDefinition> slots
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600248B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000990")]
	public IEnumerable<StyleSheet> stylesheets
	{
		[Address(RVA = "0x1B5C130", Offset = "0x1B5B330", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[IteratorStateMachine(typeof(<get_stylesheets>d__31))]
		[Token(Token = "0x6002475")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000992")]
	internal List<TemplateAsset> templateAssets
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002477")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700098F")]
	public IEnumerable<VisualTreeAsset> templateDependencies
	{
		[Address(RVA = "0x1B5C1B0", Offset = "0x1B5B3B0", Length = "0x80F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(<get_templateDependencies>d__27), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
		[Calls(Type = typeof(<get_stylesheets>d__31), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureSlotManager), Member = "FindOldestSlot", ReturnType = typeof(int))]
		[Calls(Type = typeof(TextureSlotManager), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(float), typeof(float), typeof(bool), typeof(int), typeof(MaterialPropertyBlock), typeof(CommandList)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[IteratorStateMachine(typeof(<get_templateDependencies>d__27))]
		[Token(Token = "0x6002474")]
		 get { } //Length: 2063
	}

	[Token(Token = "0x1700098E")]
	internal List<UsingEntry> usings
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002473")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000993")]
	internal List<UxmlObjectEntry> uxmlObjectEntries
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002478")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000994")]
	internal List<Int32> uxmlObjectIds
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002479")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000991")]
	internal List<VisualElementAsset> visualElementAssets
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002476")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 95
	}

	[Address(RVA = "0x1B5BD80", Offset = "0x1B5AF80", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60024A1")]
	private static VisualTreeAsset() { }

	[Address(RVA = "0x1B5BEF0", Offset = "0x1B5B0F0", Length = "0x21F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60024A0")]
	public VisualTreeAsset() { }

	[Address(RVA = "0x1B5BBF0", Offset = "0x1B5ADF0", Length = "0x182")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x60024A2")]
	internal static VisualElement <Create>g__CreateError|82_0(ref <>c__DisplayClass82_0 unnamed_param_0) { }

	[Address(RVA = "0x1B573A0", Offset = "0x1B565A0", Length = "0x38F")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "AddUxmlObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(string), typeof(UxmlNamespaceDefinition)}, ReturnType = typeof(UxmlObjectAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "AddUxmlObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(string), typeof(UxmlNamespaceDefinition)}, ReturnType = typeof(UxmlObjectAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjectEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UxmlObjectEntry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UxmlObjectEntry), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UxmlObjectAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "GetNextUxmlAssetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600247C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal UxmlObjectAsset AddUxmlObject(UxmlAsset parent, string fieldUxmlName, string fullTypeName, UxmlNamespaceDefinition xmlNamespace = null) { }

	[Address(RVA = "0x1B57730", Offset = "0x1B56930", Length = "0x1AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssetEntry), Member = "get_type", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6002483")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool AssetEntryExists(string path, Type type) { }

	[Address(RVA = "0x1B578E0", Offset = "0x1B56AE0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600249C")]
	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	[Address(RVA = "0x1B57970", Offset = "0x1B56B70", Length = "0x336")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleSheets", ReturnType = typeof(VisualElementStyleSheetSet))]
	[Calls(Type = typeof(VisualElementAsset), Member = "get_stylesheets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheet>))]
	[Calls(Type = typeof(VisualElementStyleSheetSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x600249D")]
	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	[Address(RVA = "0x1B57CB0", Offset = "0x1B56EB0", Length = "0xB06")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementAsset>>), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementAsset>>), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x6002495")]
	private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<Int32, List`1<VisualElementAsset>> idToChildren, CreationContext context) { }

	[Address(RVA = "0x1B59270", Offset = "0x1B58470", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[Token(Token = "0x6002490")]
	public TemplateContainer CloneTree() { }

	[Address(RVA = "0x1B58FF0", Offset = "0x1B581F0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002491")]
	public TemplateContainer CloneTree(string bindingPath) { }

	[Address(RVA = "0x1B587C0", Offset = "0x1B579C0", Length = "0x7F3")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemplateAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementAsset>>), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002494")]
	internal void CloneTree(VisualElement target, CreationContext cc) { }

	[Address(RVA = "0x1B59040", Offset = "0x1B58240", Length = "0x227")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(CreationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B3CB20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002493")]
	public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount) { }

	[Address(RVA = "0x1B58FC0", Offset = "0x1B581C0", Length = "0x27")]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002492")]
	public void CloneTree(VisualElement target) { }

	[Address(RVA = "0x1B59280", Offset = "0x1B58480", Length = "0x2D7")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CollectUxmlObjectAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UxmlObjectAsset>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(UxmlObjectEntry), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UxmlObjectAsset))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CollectUxmlObjectAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UxmlObjectAsset>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6002480")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void CollectUxmlObjectAssets(UxmlAsset parent, string fieldName, List<UxmlObjectAsset> foundEntries) { }

	[Address(RVA = "0x1B59560", Offset = "0x1B58760", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002496")]
	internal static int CompareForOrder(VisualElementAsset a, VisualElementAsset b) { }

	[Address(RVA = "0x1B59590", Offset = "0x1B58790", Length = "0x751")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElementAsset>>), typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "AssignStyleSheetFromAssetToElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030220")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(VisualElementFactoryRegistry), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(List`1<IUxmlFactory>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "<Create>g__CreateError|82_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass82_0&)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementFactoryRegistry), Member = "get_factories", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Collections.Generic.List`1<UnityEngine.UIElements.IUxmlFactory>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600249B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) { }

	[Address(RVA = "0x1B04A80", Offset = "0x1B03C80", Length = "0x6")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x600248C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int get_contentContainerId() { }

	[Address(RVA = "0x1B5C110", Offset = "0x1B5B310", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600249E")]
	public int get_contentHash() { }

	[Address(RVA = "0x1A76600", Offset = "0x1A75800", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600246C")]
	public bool get_importedWithErrors() { }

	[Address(RVA = "0x1B5C120", Offset = "0x1B5B320", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002470")]
	public bool get_importedWithWarnings() { }

	[Address(RVA = "0x1B2CF60", Offset = "0x1B2C160", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600246E")]
	internal bool get_importerWithUpdatedUrls() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600248B")]
	internal List<SlotDefinition> get_slots() { }

	[Address(RVA = "0x1B5C130", Offset = "0x1B5B330", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<get_stylesheets>d__31))]
	[Token(Token = "0x6002475")]
	public IEnumerable<StyleSheet> get_stylesheets() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002477")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<TemplateAsset> get_templateAssets() { }

	[Address(RVA = "0x1B5C1B0", Offset = "0x1B5B3B0", Length = "0x80F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureSlotManager), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(float), typeof(float), typeof(bool), typeof(int), typeof(MaterialPropertyBlock), typeof(CommandList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureSlotManager), Member = "FindOldestSlot", ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(<get_stylesheets>d__31), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(<get_templateDependencies>d__27), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[IteratorStateMachine(typeof(<get_templateDependencies>d__27))]
	[Token(Token = "0x6002474")]
	public IEnumerable<VisualTreeAsset> get_templateDependencies() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002473")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<UsingEntry> get_usings() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002478")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<UxmlObjectEntry> get_uxmlObjectEntries() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002479")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<Int32> get_uxmlObjectIds() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002476")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<VisualElementAsset> get_visualElementAssets() { }

	[Address(RVA = "0x1B59E60", Offset = "0x1B59060", Length = "0x1BC")]
	[CalledBy(Type = typeof(UxmlImageAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(Background))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssetEntry), Member = "get_type", ReturnType = typeof(Type))]
	[Calls(Type = typeof(AssetEntry), Member = "get_asset", ReturnType = typeof(Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002487")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal object GetAsset(string path, Type type) { }

	[Address(RVA = "0x7D2270", Offset = "0x7D1470", Length = "0x9E")]
	[CalledBy(Type = typeof(UxmlAssetAttributeDescription`1), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = "T")]
	[CalledBy(Type = typeof(UxmlAssetAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "GetAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002486")]
	internal T GetAsset(string path) { }

	[Address(RVA = "0x1B59CF0", Offset = "0x1B58EF0", Length = "0x16E")]
	[CalledBy(Type = typeof(UxmlImageAttributeDescription), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(Background))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssetEntry), Member = "get_type", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002488")]
	internal Type GetAssetType(string path) { }

	[Address(RVA = "0x1B5A020", Offset = "0x1B59220", Length = "0x163")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetNextUxmlAssetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002472")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int GetNextChildSerialNumber() { }

	[Address(RVA = "0x1B5A190", Offset = "0x1B59390", Length = "0x68")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "AddUxmlObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(string), typeof(UxmlNamespaceDefinition)}, ReturnType = typeof(UxmlObjectAsset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "GetNextChildSerialNumber", ReturnType = typeof(int))]
	[Token(Token = "0x600247D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int GetNextUxmlAssetId(int parentId) { }

	[Address(RVA = "0x1B5A200", Offset = "0x1B59400", Length = "0x138")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "RegisterUxmlObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlObjectAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "AddUxmlObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(string), typeof(UxmlNamespaceDefinition)}, ReturnType = typeof(UxmlObjectAsset))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjects", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002489")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal UxmlObjectEntry GetUxmlObjectEntry(int id) { }

	[Address(RVA = "0x1B5A340", Offset = "0x1B59540", Length = "0x3A6")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjects", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030220")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UxmlObjectFactoryRegistry), Member = "get_factories", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Collections.Generic.List`1<UnityEngine.UIElements.IBaseUxmlObjectFactory>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600248A")]
	internal IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) { }

	[Address(RVA = "0x7D26B0", Offset = "0x7D18B0", Length = "0x2BA")]
	[CalledBy(Type = typeof(UxmlObjectAttributeDescription`1), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = "T")]
	[CalledBy(Type = typeof(UxmlObjectListAttributeDescription`1), Member = "GetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = "System.Collections.Generic.List`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180030220")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjectFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlObjectAsset)}, ReturnType = typeof(IBaseUxmlObjectFactory))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjectEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UxmlObjectEntry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002482")]
	internal List<T> GetUxmlObjects(IUxmlAttributes asset, CreationContext cc) { }

	[Address(RVA = "0x1B5A6F0", Offset = "0x1B598F0", Length = "0x1C9")]
	[CalledBy(Type = typeof(ListView), Member = "TemplateMakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = "UnityEngine.UIElements.Column+UxmlObjectTraits`1+<>c__DisplayClass14_0", Member = "<Init>b__0", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = "UnityEngine.UIElements.Column+UxmlObjectTraits`1+<>c__DisplayClass14_1", Member = "<Init>b__1", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(TreeView), Member = "TemplateMakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TemplateContainer))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", ReturnType = typeof(TemplateContainer))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TemplateContainer))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(CreationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TemplateContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B3CAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x600248E")]
	public TemplateContainer Instantiate() { }

	[Address(RVA = "0x1B58FF0", Offset = "0x1B581F0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeAsset), Member = "Instantiate", ReturnType = typeof(TemplateContainer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600248F")]
	public TemplateContainer Instantiate(string bindingPath) { }

	[Address(RVA = "0x1B5A8C0", Offset = "0x1B59AC0", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AssetEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002484")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void RegisterAssetEntry(string path, Type type, object asset) { }

	[Address(RVA = "0x1B5A9D0", Offset = "0x1B59BD0", Length = "0x208")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjectEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UxmlObjectEntry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600247B")]
	internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) { }

	[Address(RVA = "0x1B5ABE0", Offset = "0x1B59DE0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "RemoveUxmlObjectEntryDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600247A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void RemoveElementAndDependencies(VisualElementAsset asset) { }

	[Address(RVA = "0x1B5AC50", Offset = "0x1B59E50", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualTreeAsset+UsingEntry>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsingEntry)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002499")]
	private void RemoveUsingEntry(UsingEntry entry) { }

	[Address(RVA = "0x1B5B150", Offset = "0x1B5A350", Length = "0x1CE")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "SetUxmlObjectAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UxmlObjectAsset>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "RemoveUxmlObjectEntryDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualTreeAsset+UxmlObjectEntry>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlObjectEntry)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600247E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void RemoveUxmlObject(int id, bool onlyIfIsField = false) { }

	[Address(RVA = "0x1B5ACC0", Offset = "0x1B59EC0", Length = "0x488")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "RemoveElementAndDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElementAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "RemoveUxmlObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "RemoveUxmlObjectEntryDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualTreeAsset+UxmlObjectEntry>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlObjectEntry)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F730")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(VisualTreeAsset), Member = "RemoveUxmlObjectEntryDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600247F")]
	private void RemoveUxmlObjectEntryDependencies(int parentId) { }

	[Address(RVA = "0x1B5B320", Offset = "0x1B5A520", Length = "0x280")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemplateAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UsingEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "LoadResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(float)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualTreeAsset+UsingEntry>), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsingEntry), typeof(System.Collections.Generic.IComparer`1<UnityEngine.UIElements.VisualTreeAsset+UsingEntry>)}, ReturnType = typeof(int))]
	[Token(Token = "0x600249A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualTreeAsset ResolveTemplate(string templateName) { }

	[Address(RVA = "0x5ECD90", Offset = "0x5EBF90", Length = "0x4")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600248D")]
	internal void set_contentContainerId(int value) { }

	[Address(RVA = "0x19DF2B0", Offset = "0x19DE4B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600249F")]
	public void set_contentHash(int value) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600246D")]
	internal void set_importedWithErrors(bool value) { }

	[Address(RVA = "0x5611C0", Offset = "0x5603C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002471")]
	internal void set_importedWithWarnings(bool value) { }

	[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600246F")]
	internal void set_importerWithUpdatedUrls(bool value) { }

	[Address(RVA = "0x1B5B5B0", Offset = "0x1B5A7B0", Length = "0x341")]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "SetUxmlObjectAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UxmlObjectAsset>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualTreeAsset+UxmlObjectEntry>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlObjectEntry)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "RemoveUxmlObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlObjectEntry), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UxmlObjectAsset))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "SetUxmlObjectAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlAsset), typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UxmlObjectAsset>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002481")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SetUxmlObjectAssets(UxmlAsset parent, string fieldName, List<UxmlObjectAsset> entries) { }

	[Address(RVA = "0x1B5B900", Offset = "0x1B5AB00", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualTreeAsset+AssetEntry>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset+AssetEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002485")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void TransferAssetEntries(VisualTreeAsset otherVta) { }

	[Address(RVA = "0x1B5B990", Offset = "0x1B5AB90", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002497")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName) { }

	[Address(RVA = "0x1B5BA70", Offset = "0x1B5AC70", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UsingEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualTreeAsset+UsingEntry>), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsingEntry), typeof(System.Collections.Generic.IComparer`1<UnityEngine.UIElements.VisualTreeAsset+UsingEntry>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002498")]
	internal bool TryGetUsingEntry(string templateName, out UsingEntry entry) { }

}

