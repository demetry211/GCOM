﻿CREATE TABLE [dbo].[ARTICLE] (
    [CODE_ARTICLE]        DECIMAL (18)    IDENTITY (1, 1) NOT NULL,
    [REF_ARTICLE]         NVARCHAR (MAX)  NOT NULL,
    [DESIGNATION_ARTICLE] NVARCHAR (MAX)  NOT NULL,
    [CODE_MARQUE]         DECIMAL (18)    NULL,
    [MARQUE_ARTICLE]      NVARCHAR (MAX)  NULL,
    [DESCRIPTION_ARTICLE] NVARCHAR (MAX)  NULL,
    [CODE_BARRE_ARTICLE]  NVARCHAR (MAX)  NULL,
    [QTE_ARTICLE]         DECIMAL (18)    NULL,
    [CODE_UNITE]          DECIMAL (18)    NULL,
    [UNITE_QTE_ARTICLE]   NVARCHAR (50)   NULL,
    [QTE_MIN_ARTICLE]     DECIMAL (18)    NULL,
    [PHOTO_ARTICLE]       IMAGE           NULL,
    [PRIX_HT_A_ARTICLE]   DECIMAL (18, 3) NULL,
    [TAUX_MAJORATION]     DECIMAL (18, 2) NULL,
    [PRIX_HT_V_ARTICLE]   DECIMAL (18, 3) NULL,
    [CODE_TVA]            DECIMAL (18)    NULL,
    [TVA_ACHAT]           DECIMAL (18)    CONSTRAINT [DF_ARTICLE_TVA_ACHAT] DEFAULT ((1)) NOT NULL,
    [TVA_ARTICLE]         DECIMAL (18, 2) NULL,
    [ETAT_ARTICLE]        BIT             NULL,
    [CODE_FAMILLE]        DECIMAL (18)    NULL,
    [CODE_CATEG]          DECIMAL (18)    NULL,
    [CODE_MAG]            DECIMAL (18)    NULL,
    [CODE_FOURNISSEUR]    DECIMAL (18)    NULL,
    [REF_FRN]             NVARCHAR (30)   CONSTRAINT [DF_ARTICLE_REF_FOURNISSEUR] DEFAULT ('') NULL,
    [STOCKABLE]           BIT             CONSTRAINT [DF_ARTICLE_STOCKABLE] DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK_ARTICLE] PRIMARY KEY CLUSTERED ([CODE_ARTICLE] ASC),
    CONSTRAINT [FK_ARTICLE_CATEGORIE] FOREIGN KEY ([CODE_CATEG]) REFERENCES [dbo].[CATEGORIE] ([CODE_CATEG]),
    CONSTRAINT [FK_ARTICLE_FAMILLE] FOREIGN KEY ([CODE_FAMILLE]) REFERENCES [dbo].[FAMILLE] ([CODE_FAMILLE]),
    CONSTRAINT [FK_ARTICLE_FOURNISSEUR] FOREIGN KEY ([CODE_FOURNISSEUR]) REFERENCES [dbo].[FOURNISSEUR] ([CODE_FOURNISSEUR]),
    CONSTRAINT [FK_ARTICLE_MARQUE] FOREIGN KEY ([CODE_MARQUE]) REFERENCES [dbo].[MARQUE] ([CODE_MARQUE]),
    CONSTRAINT [FK_ARTICLE_TVA] FOREIGN KEY ([CODE_TVA]) REFERENCES [dbo].[TVA] ([CODE_TVA]),
    CONSTRAINT [FK_ARTICLE_UNITE] FOREIGN KEY ([CODE_UNITE]) REFERENCES [dbo].[UNITE] ([CODE_UNITE])
);


GO
ALTER TABLE [dbo].[ARTICLE] NOCHECK CONSTRAINT [FK_ARTICLE_FOURNISSEUR];


GO
ALTER TABLE [dbo].[ARTICLE] NOCHECK CONSTRAINT [FK_ARTICLE_MARQUE];


GO
ALTER TABLE [dbo].[ARTICLE] NOCHECK CONSTRAINT [FK_ARTICLE_TVA];
