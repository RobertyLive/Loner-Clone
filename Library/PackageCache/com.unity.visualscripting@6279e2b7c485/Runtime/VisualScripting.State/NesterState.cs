*%%%
*%%%  Copyright (c) 1998 - 1999  Microsoft Corporation
*%%%
*%%% File:     locale.gpd
*%%% Purpose:  To provide locale dependent flexibility to the printer.
*%%% Use:      Optionally include from any gpd if locale support is desired.
*%%%
*%%% Locale Ids have been arranged in the order which is in intl.inf
*%%% In most cases the name are same as those in intl.inf
*%%% The locales for which we have a build (whose preconfigured LCIDs can
*%%% be obtained using GetSystemDefaultLCID() ) have been
*%%% put in the begining to enable efficient searching.
*%%%
*%%%


*Feature: Locale
{
    *Name: "Locale"
    *ConcealFromUI?: TRUE
    *DefaultOption: English_United_States

*IgnoreBlock: {

    *Option: Language_Neutral
    {
        *Name: "  "
        *OptionID: 0x0000
    }

    *Option: Process_Default_Language
    {
        *Name: "  "
        *OptionID: 0x0400
    }

} *% End of Ignore Block.

*%%%% LCIDs with build.

    *Option: English_United_States
    {
        *Name: "  "
        *OptionID: 0x0409
    }

    *Option: Chinese_PRC
    {
        *Name: "  "
        *OptionID: 0x0804
    }

    *Option: Chinese_Taiwan_Region
    {
        *Name: "  "
        *OptionID: 0x0404
    }

    *Option: German_Standard
    {
        *Name: "  "
        *OptionID: 0x0407
    }

    *Option: Japanese
    {
        *Name: "  "
        *OptionID: 0x0411
    }

    *Option: Korean
    {
        *Name: "  "
        *OptionID: 0x0412
    }

    *Option: Arabic_Saudi_Arabia
    {
        *Name: "  "
        *OptionID: 0x0401
    }

    *Option: Hebrew
    {
        *Name: "  "
        *OptionID: 0x040d
    }

    *Option: Thai
    {
        *Name: "  "
        *OptionI