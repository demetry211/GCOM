﻿CREATE TABLE [dbo].[REGLEMENT_CLIENT] (
    [CODE_REGLEMENT_CLIENT] DECIMAL (18)    IDENTITY (1, 1) NOT NULL,
    [CODE_FACTURE]          NVARCHAR (25)   NOT NULL,
    [DATE_REG_CLT]          DATETIME        NOT NULL,
    [MODE_REGLEMENT_CLT]    NVARCHAR (MAX)  NOT NULL,
    [MONTANT_REG_CLIENT]    DECIMAL (18, 3) NOT NULL,
    [MONTANT_PIECE]         DECIMAL (18, 3) CONSTRAINT [DF_REGLEMENT_CLIENT_MONTANT_PIECE] DEFAULT ('0') NOT NULL,
    [RESTE]                 DECIMAL (18, 3) CONSTRAINT [DF_REGLEMENT_CLIENT_RESTE] DEFAULT ('0') NOT NULL,
    [NUM_PIECE_CLIENT]      NVARCHAR (MAX)  NULL,
    [BANQUE_CLIENT]         NVARCHAR (MAX)  NULL,
    [OBSERVATION]           NVARCHAR (MAX)  NULL,
    [CODE_COMPTE_CLIENT]    DECIMAL (18)    NOT NULL,
    [TYPE_PIECE]            NVARCHAR (3)    CONSTRAINT [DF_REGLEMENT_CLIENT_TYPE_PIECE] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_REGLEMENT_CLIENT] PRIMARY KEY CLUSTERED ([CODE_REGLEMENT_CLIENT] ASC),
    CONSTRAINT [FK_REGLEMENT_CLIENT_COMPTE_CLIENT] FOREIGN KEY ([CODE_COMPTE_CLIENT]) REFERENCES [dbo].[COMPTE_CLIENT] ([CODE_COMPTE_CLIENT])
);


GO
ALTER TABLE [dbo].[REGLEMENT_CLIENT] NOCHECK CONSTRAINT [FK_REGLEMENT_CLIENT_COMPTE_CLIENT];

