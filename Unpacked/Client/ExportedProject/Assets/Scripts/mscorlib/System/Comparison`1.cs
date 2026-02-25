namespace System;

[Token(Token = "0x20000AF")]
public sealed class Comparison : MulticastDelegate
{

	[Address(RVA = "0x9B3EF0", Offset = "0x9B30F0", Length = "0xA6")]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleComplexSelector", Member = "CalculateHashes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal", Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "System.Collections.Generic.List`1<SelectorMatchRecord>"}, ReturnType = "UnityEngine.UIElements.ComputedStyle")]
	[CalledBy(Type = "RLD.PrismMath", Member = "RaycastTriangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Ray", typeof(Single&), "UnityEngine.Vector3", typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), "UnityEngine.Quaternion"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.PyramidMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Ray", typeof(Single&), "UnityEngine.Vector3", typeof(float), typeof(float), typeof(float), "UnityEngine.Quaternion"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.Object2ObjectSnap", Member = "CalculateSnapResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GameObject", "RLD.Object2ObjectSnap+Config"}, ReturnType = "RLD.Object2ObjectSnap+SnapResult")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer", typeof(int), "System.Nullable`1<Int32>", "Type[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E0")]
	public Comparison`1(object object, IntPtr method) { }

	[Address(RVA = "0x9B31D0", Offset = "0x9B23D0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E1")]
	public override int Invoke(T x, T y) { }

}

