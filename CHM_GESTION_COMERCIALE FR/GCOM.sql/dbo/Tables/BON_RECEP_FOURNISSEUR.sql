﻿CREATE TABLE [dbo].[BON_RECEP_FOURNISSEUR] (
    [CODE_BRECEP]      DECIMAL (18)    CONSTRAINT [DF_BON_RECEP_FOURNISSEUR_CODE_BRECEP] DEFAULT ((0)) NOT NULL,
    [CODE_BR_FR]       NVARCHAR (12)   NOT NULL,
    [CODE_FOURNISSEUR] DECIMAL (18)    NOT NULL,
    [DATE_BR_FR]       DATETIME        NOT NULL,
    [CODE_USER]        DECIMAL (18)    NOT NULL,
    [MNT_BR_FR]        DECIMAL (18, 3) NOT NULL,
    [CODE_MAG]         DECIMAL (18)    NOT NULL,
    [RESTE]            DECIMAL (18, 3) NOT NULL,
    [REMISE]           DECIMAL (5, 2)  NOT NULL,
    CONSTRAINT [FK_BON_RECEP_FOURNISSEUR_UTILISATEUR] FOREIGN KEY ([CODE_USER]) REFERENCES [dbo].[UTILISATEUR] ([CODE_USER])
);


GO
ALTER TABLE [dbo].[BON_RECEP_FOURNISSEUR] NOCHECK CONSTRAINT [FK_BON_RECEP_FOURNISSEUR_UTILISATEUR];
