//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace skycoin {

public class coin__SignedBlock : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal coin__SignedBlock(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(coin__SignedBlock obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~coin__SignedBlock() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_coin__SignedBlock(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public coin__Block _unnamed {
    set {
      skycoinPINVOKE.coin__SignedBlock__unnamed_set(swigCPtr, coin__Block.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.coin__SignedBlock__unnamed_get(swigCPtr);
      coin__Block ret = (cPtr == global::System.IntPtr.Zero) ? null : new coin__Block(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_GoUint8_ Sig {
    set {
      skycoinPINVOKE.coin__SignedBlock_Sig_set(swigCPtr, SWIGTYPE_p_GoUint8_.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.coin__SignedBlock_Sig_get(swigCPtr);
      SWIGTYPE_p_GoUint8_ ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_GoUint8_(cPtr, false);
      return ret;
    } 
  }

  public coin__SignedBlock() : this(skycoinPINVOKE.new_coin__SignedBlock(), true) {
  }

}

}
