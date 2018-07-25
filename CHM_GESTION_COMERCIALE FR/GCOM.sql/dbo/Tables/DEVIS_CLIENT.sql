﻿CREATE TABLE [dbo].[DEVIS_CLIENT] (
    [CODE_DC]              NVARCHAR (20)  NOT NULL,
    [DATE_DC]              DATETIME       CONSTRAINT [DF_DEVIS_CLIENT_DATE_DC] DEFAULT ('01/01/1900') NOT NULL,
    [DATE_VALIDITE]        NUMERIC (3)    CONSTRAINT [DF_DEVIS_CLIENT_DATE_VALIDITE] DEFAULT ('0') NOT NULL,
    [CODE_CLIENT]          DECIMAL (18)   NOT NULL,
    [MODE_PAIEMENT]        NVARCHAR (MAX) NOT NULL,
    [OBSERVATION]          NVARCHAR (MAX) NOT NULL,
    [UTILISATEUR_CREATION] DECIMAL (18)   NOT NULL,
    [DATE_CREATION]        DATETIME       CONSTRAINT [DF_DEVIS_CLIENT_DATE_CREATION] DEFAULT ('01/01/1900') NOT NULL,
    [RESPONSABLE]          NVARCHAR (50)  CONSTRAINT [DF_DEVIS_CLIENT_RESPONSABLE] DEFAULT ('') NOT NULL,
    [NB_IMPRIME]           NUMERIC (2)    CONSTRAINT [DF_DEVIS_CLIENT_NB_IMPRIME] DEFAULT ('0') NOT NULL,
    [TIMBRE]               DECIMAL (6, 3) CONSTRAINT [DF_DEVIS_CLIENT_TIMBRE] DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK_DEVIS_CLIENT] PRIMARY KEY CLUSTERED ([CODE_DC] ASC),
    CONSTRAINT [FK_DEVIS_CLIENT_CLIENT] FOREIGN KEY ([CODE_CLIENT]) REFERENCES [dbo].[CLIENT] ([CODE_CLIENT]),
    CONSTRAINT [FK_DEVIS_CLIENT_UTILISATEUR] FOREIGN KEY ([UTILISATEUR_CREATION]) REFERENCES [dbo].[UTILISATEUR] ([CODE_USER])
);


GO
ALTER TABLE [dbo].[DEVIS_CLIENT] NOCHECK CONSTRAINT [FK_DEVIS_CLIENT_CLIENT];


GO
ALTER TABLE [dbo].[DEVIS_CLIENT] NOCHECK CONSTRAINT [FK_DEVIS_CLIENT_UTILISATEUR];
