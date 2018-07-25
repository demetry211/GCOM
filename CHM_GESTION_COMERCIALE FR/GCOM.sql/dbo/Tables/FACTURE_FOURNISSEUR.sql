﻿CREATE TABLE [dbo].[FACTURE_FOURNISSEUR] (
    [CODE_FACTURE_FOURNISSEUR] NVARCHAR (20) NOT NULL,
    [NUM_FACT_FR]              NVARCHAR (20) NOT NULL,
    [DATE_FACTURE_FOURNISSEUR] DATETIME      NOT NULL,
    [CODE_FOURNISSEUR]         DECIMAL (18)  NOT NULL,
    [USER_CREATION]            DECIMAL (18)  NOT NULL,
    [DATE_CREATION]            DATETIME      NULL,
    [USER_MODIFICATION]        DECIMAL (18)  NULL,
    [DATE_MODIFICATION]        DATETIME      NULL,
    [ANNULEE]                  BIT           NULL,
    [USER_ANNULATION]          DECIMAL (18)  NULL,
    [DATE_ANNULATION]          DATETIME      NULL,
    CONSTRAINT [PK_FACTURE_FOURNISSEUR] PRIMARY KEY CLUSTERED ([CODE_FACTURE_FOURNISSEUR] ASC),
    CONSTRAINT [FK_FACTURE_FOURNISSEUR_FOURNISSEUR] FOREIGN KEY ([CODE_FOURNISSEUR]) REFERENCES [dbo].[FOURNISSEUR] ([CODE_FOURNISSEUR])
);


GO
ALTER TABLE [dbo].[FACTURE_FOURNISSEUR] NOCHECK CONSTRAINT [FK_FACTURE_FOURNISSEUR_FOURNISSEUR];
