namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000063")]
public class PostProcessEffectSettings : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000064")]
	private sealed class <>c
	{
		[Token(Token = "0x4000192")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000193")]
		public static Func<FieldInfo, Boolean> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x4000194")]
		public static Func<FieldInfo, Int32> <>9__3_1; //Field offset: 0x10

		[Address(RVA = "0x1856120", Offset = "0x1855320", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600011E")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011F")]
		public <>c() { }

		[Address(RVA = "0x1855BC0", Offset = "0x1854DC0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000120")]
		internal bool <OnEnable>b__3_0(FieldInfo t) { }

		[Address(RVA = "0x1855C60", Offset = "0x1854E60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000121")]
		internal int <OnEnable>b__3_1(FieldInfo t) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400018F")]
	public bool active; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000190")]
	public BoolParameter enabled; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000191")]
	internal ReadOnlyCollection<ParameterOverride> parameters; //Field offset: 0x28

	[Address(RVA = "0x1843D50", Offset = "0x1842F50", Length = "0x9D")]
	[CalledBy(Type = typeof(LensDistortion), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoExposure), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bloom), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChromaticAberration), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOfField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Grain), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MotionBlur), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceReflections), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x600011C")]
	public PostProcessEffectSettings() { }

	[Address(RVA = "0x1843CB0", Offset = "0x1842EB0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600011D")]
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }

	[Address(RVA = "0x18432A0", Offset = "0x18424A0", Length = "0x1D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600011B")]
	public int GetHash() { }

	[Address(RVA = "0x1843480", Offset = "0x1842680", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011A")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	[Address(RVA = "0x18434A0", Offset = "0x18426A0", Length = "0x1B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000118")]
	private void OnDisable() { }

	[Address(RVA = "0x1843660", Offset = "0x1842860", Length = "0x465")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(List`1), Member = "AsReadOnly", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000117")]
	private void OnEnable() { }

	[Address(RVA = "0x1843AD0", Offset = "0x1842CD0", Length = "0x1DE")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000119")]
	public void SetAllOverridesTo(bool state, bool excludeEnabled = true) { }

}

