//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public partial class MethodBase_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__MethodBase.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.MethodBase), typeof(global::System.Reflection.MethodBase_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.MethodBase), typeof(global::System.Reflection.MethodBase_))]
    internal sealed partial class @__MethodBase : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__MethodBase(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Reflection.@__MethodBase.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__MethodBase);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetParameters", "GetParameters0", "()[Lsystem/reflection/ParameterInfo;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetMethodImplementationFlags", "GetMethodImplementationFlags1", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMethodHandle", "MethodHandle2", "()Lsystem/ValueType;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAttributes", "Attributes3", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCallingConvention", "CallingConvention4", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke", "Invoke5", "(Lsystem/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Object;Ls" +
                        "ystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isPublic", "IsPublic6", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isPrivate", "IsPrivate7", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isFamily", "IsFamily8", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isAssembly", "IsAssembly9", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isFamilyAndAssembly", "IsFamilyAndAssembly10", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isFamilyOrAssembly", "IsFamilyOrAssembly11", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isStatic", "IsStatic12", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isFinal", "IsFinal13", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isVirtual", "IsVirtual14", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isHideBySig", "IsHideBySig15", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isAbstract", "IsAbstract16", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isSpecialName", "IsSpecialName17", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isConstructor", "IsConstructor18", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Invoke", "Invoke19", "(Lsystem/Object;[Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetMethodFromHandle", "GetMethodFromHandle20", "(Lsystem/ValueType;)Lsystem/reflection/MethodBase;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetMethodFromHandle", "GetMethodFromHandle21", "(Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/MethodBase;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCurrentMethod", "GetCurrentMethod22", "()Lsystem/reflection/MethodBase;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetGenericArguments", "GetGenericArguments23", "()[Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isGenericMethodDefinition", "IsGenericMethodDefinition24", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getContainsGenericParameters", "ContainsGenericParameters25", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isGenericMethod", "IsGenericMethod26", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetMethodBody", "GetMethodBody27", "()Lsystem/Object;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetParameters0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lsystem/reflection/ParameterInfo;
            // ()[LSystem/Reflection/ParameterInfo;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<System.Reflection.ParameterInfo[], global::System.Reflection.ParameterInfo>(@__env, ((global::System.Runtime.InteropServices._MethodBase)(@__real)).GetParameters());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetMethodImplementationFlags1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/MethodImplAttributes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodImplAttributes>(@__env, ((global::System.Runtime.InteropServices._MethodBase)(@__real)).GetMethodImplementationFlags());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle MethodHandle2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/ValueType;
            // ()LSystem/RuntimeMethodHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.RuntimeMethodHandle>(@__env, ((global::System.Runtime.InteropServices._MethodBase)(@__real)).MethodHandle);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Attributes3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/MethodAttributes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodAttributes>(@__env, ((global::System.Runtime.InteropServices._MethodBase)(@__real)).Attributes);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CallingConvention4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/CallingConventions;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.CallingConventions>(@__env, ((global::System.Runtime.InteropServices._MethodBase)(@__real)).CallingConvention);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Invoke5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle obj, global::net.sf.jni4net.utils.JniLocalHandle invokeAttr, global::net.sf.jni4net.utils.JniLocalHandle binder, global::net.sf.jni4net.utils.JniLocalHandle parameters, global::net.sf.jni4net.utils.JniLocalHandle culture) {
            // (Lsystem/Object;Lsystem/reflection/BindingFlags;Lsystem/Object;[Lsystem/Object;Lsystem/Object;)Lsystem/Object;
            // (LSystem/Object;LSystem/Reflection/BindingFlags;LSystem/Reflection/Binder;[LSystem/Object;LSystem/Globalization/CultureInfo;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, ((global::System.Runtime.InteropServices._MethodBase)(@__real)).Invoke(global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, obj), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.BindingFlags>(@__env, invokeAttr), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.Binder>(@__env, binder), global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<object[], object>(@__env, parameters), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Globalization.CultureInfo>(@__env, culture)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsPublic6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsPublic));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsPrivate7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsPrivate));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsFamily8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsFamily));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsAssembly9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsAssembly));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsFamilyAndAssembly10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsFamilyAndAssembly));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsFamilyOrAssembly11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsFamilyOrAssembly));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsStatic12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsStatic));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsFinal13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsFinal));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsVirtual14(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsVirtual));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsHideBySig15(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsHideBySig));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsAbstract16(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsAbstract));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsSpecialName17(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsSpecialName));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsConstructor18(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(((global::System.Runtime.InteropServices._MethodBase)(@__real)).IsConstructor));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Invoke19(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle obj, global::net.sf.jni4net.utils.JniLocalHandle parameters) {
            // (Lsystem/Object;[Lsystem/Object;)Lsystem/Object;
            // (LSystem/Object;[LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, ((global::System.Runtime.InteropServices._MethodBase)(@__real)).Invoke(global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, obj), global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<object[], object>(@__env, parameters)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetMethodFromHandle20(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle handle) {
            // (Lsystem/ValueType;)Lsystem/reflection/MethodBase;
            // (LSystem/RuntimeMethodHandle;)LSystem/Reflection/MethodBase;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodBase>(@__env, global::System.Reflection.MethodBase.GetMethodFromHandle(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.RuntimeMethodHandle>(@__env, handle)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetMethodFromHandle21(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle handle, global::net.sf.jni4net.utils.JniLocalHandle declaringType) {
            // (Lsystem/ValueType;Lsystem/ValueType;)Lsystem/reflection/MethodBase;
            // (LSystem/RuntimeMethodHandle;LSystem/RuntimeTypeHandle;)LSystem/Reflection/MethodBase;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodBase>(@__env, global::System.Reflection.MethodBase.GetMethodFromHandle(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.RuntimeMethodHandle>(@__env, handle), global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.RuntimeTypeHandle>(@__env, declaringType)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetCurrentMethod22(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class) {
            // ()Lsystem/reflection/MethodBase;
            // ()LSystem/Reflection/MethodBase;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodBase>(@__env, global::System.Reflection.MethodBase.GetCurrentMethod());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetGenericArguments23(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Lsystem/Type;
            // ()[LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayStrongC2Jp<System.Type[], global::System.Type>(@__env, @__real.GetGenericArguments());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsGenericMethodDefinition24(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(@__real.IsGenericMethodDefinition));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool ContainsGenericParameters25(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(@__real.ContainsGenericParameters));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool IsGenericMethod26(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = ((bool)(@__real.IsGenericMethod));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle GetMethodBody27(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Reflection/MethodBody;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.Reflection.MethodBase @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.MethodBase>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Reflection.MethodBody>(@__env, @__real.GetMethodBody());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__MethodBase(@__env);
            }
        }
    }
    #endregion
}
