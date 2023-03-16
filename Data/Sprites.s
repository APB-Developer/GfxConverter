;*********************************************************
;* File: Data\Sprites.s
;* Automatically generated file - please do not edit
;*********************************************************

SPR_Image_Width:                     EQU	58
SPR_Image_Height:                    EQU	49
SPR_Image_DataSize:                  EQU	1421

SPR_Frame1_Width:                    EQU	16
SPR_Frame1_Height:                   EQU	16
SPR_Frame1_DataSize:                 EQU	128

SPR_Frame1Mask_Width:                EQU	16
SPR_Frame1Mask_Height:               EQU	16
SPR_Frame1Mask_DataSize:             EQU	128

SPR_Frame1Masked_Width:              EQU	16
SPR_Frame1Masked_Height:             EQU	16
SPR_Frame1Masked_DataSize:           EQU	256

SPR_Frame2Masked_Width:              EQU	16
SPR_Frame2Masked_Height:             EQU	16
SPR_Frame2Masked_DataSize:           EQU	256


PAL_Main_Length:                     EQU	16


SPR_Image:
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x11, 0x11, 0x11
                                     DB	0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x11, 0x10, 0x00, 0x00, 0x01, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x11, 0x11, 0x11, 0x10, 0x00, 0x11, 0x11, 0x11, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x11, 0x11, 0x11
                                     DB	0x10, 0x11, 0x11, 0x12, 0x22, 0x22, 0x22, 0x22, 0x22, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x11, 0x11, 0x22, 0x22, 0x20, 0x11, 0x11
                                     DB	0x22, 0x22, 0x22, 0x22, 0x22, 0x23, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01
                                     DB	0x11, 0x11, 0x11, 0x10, 0x00, 0x11, 0x11, 0x22, 0x22, 0x22, 0x20, 0x01, 0x12, 0x22, 0x22, 0x22
                                     DB	0x22, 0x22, 0x33, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x11, 0x11, 0x11
                                     DB	0x11, 0x11, 0x01, 0x12, 0x22, 0x22, 0x22, 0x20, 0x11, 0x22, 0x22, 0x22, 0x22, 0x22, 0x23, 0x33
                                     DB	0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x01
                                     DB	0x12, 0x22, 0x22, 0x22, 0x20, 0x02, 0x22, 0x22, 0x22, 0x22, 0x23, 0x33, 0x33, 0x30, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x11, 0x22, 0x22, 0x22, 0x22, 0x01, 0x22, 0x22, 0x22
                                     DB	0x22, 0x33, 0x00, 0x22, 0x22, 0x22, 0x23, 0x33, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x02, 0x11, 0x22, 0x22, 0x22, 0x22, 0x33, 0x02, 0x22, 0x22, 0x22, 0x22, 0x33, 0x00
                                     DB	0x00, 0x00, 0x03, 0x33, 0x33, 0x33, 0x00, 0x01, 0x11, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01
                                     DB	0x22, 0x22, 0x22, 0x22, 0x23, 0x30, 0x32, 0x22, 0x22, 0x22, 0x23, 0x33, 0x00, 0x00, 0x11, 0x10
                                     DB	0x33, 0x33, 0x33, 0x00, 0x11, 0x11, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x22, 0x22, 0x22
                                     DB	0x22, 0x33, 0x00, 0x33, 0x22, 0x22, 0x23, 0x33, 0x30, 0x01, 0x11, 0x11, 0x11, 0x00, 0x03, 0x30
                                     DB	0x01, 0x11, 0x11, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x23, 0x30, 0x00
                                     DB	0x03, 0x33, 0x33, 0x33, 0x33, 0x00, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x30, 0x11, 0x11, 0x22
                                     DB	0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x33, 0x23, 0x33, 0x33, 0x00, 0x11, 0x10, 0x33, 0x33
                                     DB	0x33, 0x00, 0x01, 0x11, 0x11, 0x21, 0x11, 0x22, 0x20, 0x00, 0x11, 0x12, 0x22, 0x22, 0x23, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x03, 0x33, 0x33, 0x30, 0x01, 0x11, 0x11, 0x00, 0x00, 0x00, 0x33, 0x01
                                     DB	0x11, 0x12, 0x11, 0x12, 0x22, 0x23, 0x00, 0x01, 0x22, 0x22, 0x22, 0x23, 0x30, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x03, 0x33, 0x30, 0x11, 0x11, 0x11, 0x00, 0x30, 0x30, 0x30, 0x11, 0x11, 0x21, 0x12
                                     DB	0x22, 0x23, 0x23, 0x00, 0x22, 0x22, 0x22, 0x22, 0x23, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x30, 0x11, 0x12, 0x11, 0x22, 0x03, 0x33, 0x00, 0x11, 0x12, 0x21, 0x22, 0x23, 0x33, 0x33
                                     DB	0x30, 0x22, 0x22, 0x22, 0x22, 0x33, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x11, 0x00, 0x11
                                     DB	0x12, 0x11, 0x22, 0x00, 0x33, 0x01, 0x11, 0x12, 0x11, 0x22, 0x33, 0x32, 0x32, 0x30, 0x02, 0x22
                                     DB	0x22, 0x33, 0x33, 0x30, 0x00, 0x00, 0x00, 0x00, 0x01, 0x11, 0x11, 0x10, 0x01, 0x11, 0x12, 0x22
                                     DB	0x20, 0x33, 0x01, 0x11, 0x22, 0x12, 0x22, 0x33, 0x22, 0x22, 0x33, 0x00, 0x03, 0x33, 0x33, 0x33
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x11, 0x11, 0x10, 0x01, 0x21, 0x12, 0x22, 0x22, 0x00, 0x01
                                     DB	0x12, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x33, 0x30, 0x00, 0x00, 0x33, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x11, 0x22, 0x22, 0x22, 0x01, 0x21, 0x12, 0x22, 0x22, 0x03, 0x01, 0x22, 0x22, 0x22
                                     DB	0x32, 0x22, 0x22, 0x23, 0x33, 0x30, 0x03, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x12
                                     DB	0x22, 0x22, 0x22, 0x00, 0x21, 0x22, 0x22, 0x22, 0x00, 0x02, 0x22, 0x22, 0x22, 0x22, 0x22, 0x23
                                     DB	0x33, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x23
                                     DB	0x30, 0x22, 0x22, 0x22, 0x22, 0x20, 0x02, 0x22, 0x22, 0x22, 0x22, 0x22, 0x33, 0x33, 0x33, 0x30
                                     DB	0x00, 0x11, 0x11, 0x11, 0x10, 0x00, 0x00, 0x00, 0x00, 0x03, 0x33, 0x23, 0x33, 0x00, 0x01, 0x22
                                     DB	0x22, 0x22, 0x23, 0x02, 0x22, 0x22, 0x22, 0x22, 0x22, 0x33, 0x33, 0x33, 0x30, 0x11, 0x11, 0x11
                                     DB	0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 0x00, 0x03, 0x33, 0x33, 0x03, 0x02, 0x22, 0x22, 0x22, 0x22
                                     DB	0x30, 0x22, 0x22, 0x22, 0x22, 0x33, 0x32, 0x23, 0x33, 0x30, 0x11, 0x11, 0x22, 0x22, 0x22, 0x22
                                     DB	0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x33, 0x02, 0x22, 0x22, 0x22, 0x23, 0x30, 0x02, 0x22
                                     DB	0x22, 0x33, 0x32, 0x22, 0x33, 0x33, 0x30, 0x11, 0x12, 0x22, 0x22, 0x22, 0x22, 0x33, 0x00, 0x00
                                     DB	0x00, 0x01, 0x10, 0x00, 0x00, 0x02, 0x22, 0x22, 0x22, 0x23, 0x33, 0x00, 0x22, 0x22, 0x22, 0x22
                                     DB	0x33, 0x33, 0x33, 0x30, 0x11, 0x22, 0x22, 0x22, 0x22, 0x22, 0x33, 0x30, 0x00, 0x00, 0x11, 0x11
                                     DB	0x11, 0x10, 0x02, 0x22, 0x22, 0x22, 0x23, 0x03, 0x33, 0x00, 0x02, 0x33, 0x33, 0x33, 0x33, 0x33
                                     DB	0x30, 0x11, 0x22, 0x22, 0x22, 0x22, 0x22, 0x33, 0x30, 0x00, 0x00, 0x11, 0x11, 0x11, 0x11, 0x00
                                     DB	0x22, 0x22, 0x22, 0x33, 0x03, 0x30, 0x20, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x00, 0x22, 0x22
                                     DB	0x22, 0x22, 0x22, 0x23, 0x33, 0x30, 0x00, 0x00, 0x11, 0x11, 0x11, 0x11, 0x00, 0x22, 0x22, 0x22
                                     DB	0x33, 0x00, 0x02, 0x12, 0x20, 0x00, 0x03, 0x00, 0x30, 0x00, 0x03, 0x02, 0x22, 0x22, 0x22, 0x22
                                     DB	0x33, 0x33, 0x00, 0x00, 0x00, 0x11, 0x12, 0x22, 0x21, 0x10, 0x22, 0x22, 0x22, 0x33, 0x30, 0x01
                                     DB	0x22, 0x33, 0x03, 0x30, 0x00, 0x00, 0x00, 0x03, 0x30, 0x22, 0x22, 0x22, 0x23, 0x33, 0x33, 0x00
                                     DB	0x00, 0x00, 0x11, 0x21, 0x12, 0x22, 0x20, 0x22, 0x22, 0x23, 0x33, 0x30, 0x02, 0x22, 0x30, 0x30
                                     DB	0x01, 0x00, 0x11, 0x11, 0x10, 0x00, 0x03, 0x33, 0x33, 0x33, 0x33, 0x30, 0x00, 0x00, 0x00, 0x11
                                     DB	0x22, 0x22, 0x22, 0x20, 0x22, 0x22, 0x23, 0x23, 0x33, 0x02, 0x23, 0x30, 0x30, 0x11, 0x11, 0x11
                                     DB	0x11, 0x11, 0x10, 0x03, 0x33, 0x33, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x22
                                     DB	0x20, 0x22, 0x23, 0x22, 0x23, 0x33, 0x02, 0x33, 0x30, 0x01, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11
                                     DB	0x10, 0x03, 0x33, 0x33, 0x30, 0x00, 0x00, 0x00, 0x02, 0x22, 0x22, 0x22, 0x22, 0x20, 0x22, 0x22
                                     DB	0x23, 0x33, 0x30, 0x00, 0x00, 0x00, 0x11, 0x11, 0x11, 0x11, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00
                                     DB	0x33, 0x00, 0x00, 0x00, 0x00, 0x02, 0x22, 0x22, 0x22, 0x22, 0x33, 0x02, 0x33, 0x33, 0x33, 0x33
                                     DB	0x00, 0x00, 0x11, 0x11, 0x11, 0x12, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x23, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x02, 0x22, 0x22, 0x22, 0x22, 0x30, 0x00, 0x33, 0x33, 0x33, 0x33, 0x03, 0x00, 0x11
                                     DB	0x11, 0x12, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x02
                                     DB	0x22, 0x22, 0x22, 0x23, 0x30, 0x30, 0x33, 0x33, 0x33, 0x30, 0x03, 0x01, 0x11, 0x12, 0x22, 0x22
                                     DB	0x22, 0x22, 0x22, 0x22, 0x22, 0x23, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x03, 0x22, 0x22, 0x22
                                     DB	0x23, 0x30, 0x30, 0x00, 0x00, 0x00, 0x00, 0x33, 0x00, 0x11, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22
                                     DB	0x22, 0x22, 0x33, 0x32, 0x33, 0x30, 0x00, 0x00, 0x00, 0x03, 0x33, 0x22, 0x22, 0x33, 0x30, 0x00
                                     DB	0x11, 0x11, 0x11, 0x11, 0x00, 0x30, 0x12, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x33, 0x33
                                     DB	0x23, 0x33, 0x30, 0x00, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x30, 0x11, 0x11, 0x11, 0x11
                                     DB	0x11, 0x11, 0x00, 0x02, 0x22, 0x22, 0x22, 0x22, 0x22, 0x23, 0x23, 0x33, 0x32, 0x33, 0x33, 0x33
                                     DB	0x00, 0x00, 0x00, 0x00, 0x03, 0x33, 0x33, 0x33, 0x30, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x10
                                     DB	0x00, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x22, 0x33, 0x33, 0x33, 0x33, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x33, 0x33, 0x33, 0x00, 0x11, 0x11, 0x22, 0x22, 0x22, 0x22, 0x10, 0x00, 0x00, 0x03
                                     DB	0x33, 0x32, 0x23, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x30, 0x00, 0x00, 0x01, 0x22, 0x22, 0x22, 0x22, 0x22, 0x30, 0x00, 0x00, 0x00, 0x03, 0x33, 0x33
                                     DB	0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x22, 0x22, 0x22, 0x22, 0x33, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33
                                     DB	0x33, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22
                                     DB	0x22, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x33, 0x30
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x33, 0x33
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00

SPR_Frame1:
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01
                                     DB	0x00, 0x01, 0x11, 0x11, 0x11, 0x10, 0x00, 0x11, 0x00, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x01
                                     DB	0x00, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x01, 0x00, 0x11, 0x11, 0x22, 0x22, 0x22, 0x22, 0x01
                                     DB	0x02, 0x11, 0x22, 0x22, 0x22, 0x22, 0x33, 0x02, 0x01, 0x22, 0x22, 0x22, 0x22, 0x23, 0x30, 0x32
                                     DB	0x01, 0x22, 0x22, 0x22, 0x22, 0x33, 0x00, 0x33, 0x00, 0x22, 0x22, 0x22, 0x23, 0x30, 0x00, 0x03
                                     DB	0x00, 0x33, 0x23, 0x33, 0x33, 0x00, 0x11, 0x10, 0x00, 0x03, 0x33, 0x33, 0x30, 0x01, 0x11, 0x11

SPR_Frame1Mask:
                                     DB	0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF
                                     DB	0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF
                                     DB	0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0xFF, 0xF0, 0x00, 0x00, 0x00, 0x0F, 0xF0, 0x00
                                     DB	0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00

SPR_Frame1Masked:
                                     DB	0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00
                                     DB	0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00
                                     DB	0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00
                                     DB	0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00
                                     DB	0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0x00, 0x00
                                     DB	0xFF, 0x00, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0xF0, 0x00, 0x00, 0x01
                                     DB	0xFF, 0x00, 0x00, 0x01, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x10, 0x00, 0x00, 0x00, 0x11
                                     DB	0xF0, 0x00, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x01
                                     DB	0xF0, 0x00, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x01
                                     DB	0x00, 0x00, 0x00, 0x11, 0x00, 0x11, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x01
                                     DB	0x00, 0x02, 0x00, 0x11, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x33, 0x00, 0x02
                                     DB	0x00, 0x01, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x23, 0x00, 0x30, 0x00, 0x32
                                     DB	0x00, 0x01, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x33, 0x00, 0x00, 0x00, 0x33
                                     DB	0xF0, 0x00, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x23, 0x00, 0x30, 0x00, 0x00, 0x00, 0x03
                                     DB	0xF0, 0x00, 0x00, 0x33, 0x00, 0x23, 0x00, 0x33, 0x00, 0x33, 0x00, 0x00, 0x00, 0x11, 0x00, 0x10
                                     DB	0xF0, 0x00, 0x00, 0x03, 0x00, 0x33, 0x00, 0x33, 0x00, 0x30, 0x00, 0x01, 0x00, 0x11, 0x00, 0x11

SPR_Frame2Masked:
                                     DB	0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0x00
                                     DB	0x00, 0xFF, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x0F, 0x00, 0xFF, 0x00, 0xFF, 0x00, 0x00, 0x11, 0x00
                                     DB	0x00, 0xFF, 0x00, 0x00, 0x11, 0x00, 0x10, 0x00, 0x00, 0x0F, 0x00, 0xF0, 0x01, 0x00, 0x11, 0x00
                                     DB	0x00, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x10, 0x00, 0x00, 0x00, 0x11, 0x00, 0x11, 0x00
                                     DB	0x01, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00, 0x10, 0x00, 0x11, 0x00, 0x11, 0x00, 0x12, 0x00
                                     DB	0x11, 0x00, 0x11, 0x00, 0x22, 0x00, 0x22, 0x00, 0x20, 0x00, 0x11, 0x00, 0x11, 0x00, 0x22, 0x00
                                     DB	0x11, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x20, 0x00, 0x01, 0x00, 0x12, 0x00, 0x22, 0x00
                                     DB	0x12, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x20, 0x00, 0x11, 0x00, 0x22, 0x00, 0x22, 0x00
                                     DB	0x12, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x20, 0x00, 0x02, 0x00, 0x22, 0x00, 0x22, 0x00
                                     DB	0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x33, 0x00, 0x00, 0x00, 0x22, 0x00, 0x22, 0x00
                                     DB	0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                                     DB	0x22, 0x00, 0x22, 0x00, 0x22, 0x00, 0x23, 0x00, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x00
                                     DB	0x22, 0x00, 0x22, 0x00, 0x23, 0x00, 0x33, 0x00, 0x30, 0x00, 0x01, 0x00, 0x11, 0x00, 0x11, 0x00
                                     DB	0x33, 0x00, 0x33, 0x00, 0x33, 0x00, 0x33, 0x00, 0x00, 0x00, 0x11, 0x00, 0x11, 0x00, 0x11, 0x00
                                     DB	0x33, 0x00, 0x33, 0x00, 0x33, 0x00, 0x00, 0x00, 0x01, 0x00, 0x11, 0x00, 0x11, 0x00, 0x21, 0x00
                                     DB	0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x33, 0x00, 0x01, 0x00, 0x11, 0x00, 0x12, 0x00, 0x11, 0x00


PAL_Main:
                                     DB	0x00, 0x3F, 0x30, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3F

