﻿CREATE TABLE [dbo].[TRACE_BON_RECEP_FOURNISSEUR] (
    [ORDRE]             DECIMAL (18)    IDENTITY (1, 1) NOT NULL,
    [CODE_BRECEP]       DECIMAL (18)    CONSTRAINT [DF_TRACE_BON_RECEP_FOURNISSEUR_CODE_BRECEP] DEFAULT ((0)) NOT NULL,
    [CODE_BR_FR]        NVARCHAR (12)   NOT NULL,
    [CODE_FOURNISSEUR]  DECIMAL (18)    NOT NULL,
    [DATE_BR_FR]        DATETIME        NOT NULL,
    [CODE_USER]         DECIMAL (18)    NOT NULL,
    [MNT_BR_FR]         DECIMAL (18, 3) NOT NULL,
    [CODE_MAG]          DECIMAL (18)    NOT NULL,
    [RESTE]             DECIMAL (18, 3) NOT NULL,
    [REMISE]            DECIMAL (5, 2)  NOT NULL,
    [DATE_MODIFICATION] DATETIME        NULL,
    [TYPE_TRACE]        NCHAR (1)       NULL,
    CONSTRAINT [PK_TRACE_BON_RECEP_FOURNISSEUR] PRIMARY KEY CLUSTERED ([ORDRE] ASC)
);
