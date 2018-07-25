﻿CREATE TABLE [dbo].[TICKET_CAISSE] (
    [CODE_TC]        NVARCHAR (25)   NOT NULL,
    [DATE_TC]        DATETIME        NULL,
    [CODE_CAISSE]    DECIMAL (18)    NULL,
    [CODE_CLIENT]    DECIMAL (18)    NOT NULL,
    [MONTANT_HT]     DECIMAL (18, 3) NOT NULL,
    [REMISE]         DECIMAL (18, 3) CONSTRAINT [DF_TICKET_CAISSE_REMISE] DEFAULT ('0') NOT NULL,
    [MONTANT_TVA]    DECIMAL (18, 3) NOT NULL,
    [MONTANT_TTC]    DECIMAL (18, 3) NOT NULL,
    [MONTANT_RECU]   DECIMAL (18, 3) NOT NULL,
    [RESTE]          DECIMAL (18, 3) NOT NULL,
    [MAGASIN]        DECIMAL (18)    NOT NULL,
    [CODE_USER]      DECIMAL (18)    NOT NULL,
    [CODE_REGLEMENT] DECIMAL (18)    NOT NULL,
    [CODE_FACTURE]   NVARCHAR (25)   CONSTRAINT [DF_TICKET_CAISSE_CODE_FACTURE] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_TICKET_CAISSE] PRIMARY KEY CLUSTERED ([CODE_TC] ASC)
);
