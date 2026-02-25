namespace UnityEngine.Pool;

[Token(Token = "0x200027E")]
public class GenericPool
{
	[CompilerGenerated]
	[Token(Token = "0x200027F")]
	private sealed class <>c
	{
		[Token(Token = "0x40006A2")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CDE")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CDF")]
		public <>c() { }

		[Address(RVA = "0x7F9CD0", Offset = "0x7F8ED0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CE0")]
		internal T <.cctor>b__5_0() { }

	}

	[Token(Token = "0x40006A1")]
	internal static readonly ObjectPool<T> s_Pool; //Field offset: 0x0

	[Address(RVA = "0xC58170", Offset = "0xC57370", Length = "0x23D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CDD")]
	private static GenericPool`1() { }

	[Address(RVA = "0xC57E10", Offset = "0xC57010", Length = "0x176")]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.UIElements.EventCallback`1<TEventType>", "UnityEngine.UIElements.InvokePolicy"}, ReturnType = "UnityEngine.UIElements.EventCallbackFunctor`1<TEventType>")]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`2", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", "UnityEngine.UIElements.InvokePolicy"}, ReturnType = "UnityEngine.UIElements.EventCallbackFunctor`2<TEventType, TCallbackArgs>")]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster+CameraRayEnumerator", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Camera[]", typeof(int), typeof(Vector2), "System.Nullable`1<Int32>"}, ReturnType = "UnityEngine.UIElements.CameraScreenRaycaster+CameraRayEnumerator")]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster", Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), "System.Nullable`1<Int32>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<ValueTuple`3<Ray, Camera, Boolean>>")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheetUtility", Member = "ConvertDashToUpperNoSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CDB")]
	public static T Get() { }

	[Address(RVA = "0xC57F90", Offset = "0xC57190", Length = "0x1D4")]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`1", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`2", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.CameraScreenRaycaster+CameraRayEnumerator", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TransformOrigin+PropertyBag+ZProperty", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheetUtility", Member = "ConvertDashToUpperNoSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CDC")]
	public static void Release(T toRelease) { }

}

