; Assembly listing for method Program:FloatToUint(float):uint (FullOpts)
; Emitting BLENDED_CODE for generic X64 - Windows
; FullOpts code
; optimized code
; rsp based frame
; partially interruptible
; No PGO data

G_M000_IG01:                ;; offset=0x0000
 
G_M000_IG02:                ;; offset=0x0000
       F3480F2CC0           cvttss2si  rax, xmm0
 
G_M000_IG03:                ;; offset=0x0005
       C3                   ret      
 
; Total bytes of code 6