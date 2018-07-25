﻿CREATE TABLE [dbo].[FICHE_INTERVENTION] (
    [NUM_FI]         NVARCHAR (20)   NOT NULL,
    [DATE_FI]        DATETIME        NULL,
    [CODE_VEHICULE]  DECIMAL (18)    NOT NULL,
    [KILOMETRAGE]    DECIMAL (18, 1) CONSTRAINT [DF_FICHE_INTERVENTION_KILOMETRAGE] DEFAULT ('0') NULL,
    [CODE_B_LIV]     NVARCHAR (450)  NOT NULL,
    [USER_CR]        DECIMAL (18)    NULL,
    [DATE_MODIF]     DATETIME        CONSTRAINT [DF_FICHE_INTERVENTION_DATE_MODIF] DEFAULT ('01/01/1900') NULL,
    [USER_MODIF]     DECIMAL (18)    NULL,
    [CLOTURE]        BIT             NULL,
    [DATE_CLOTURE]   DATETIME        NULL,
    [USER_CLOTURE]   DECIMAL (18)    NULL,
    [TYPE_PIECE_REG] NVARCHAR (3)    CONSTRAINT [DF_FICHE_INTERVENTION_TYPE_PIECE_REG] DEFAULT ('') NOT NULL,
    [CODE_MAG]       DECIMAL (18)    NULL,
    CONSTRAINT [PK_FICHE_INTERVENTION] PRIMARY KEY CLUSTERED ([NUM_FI] ASC),
    CONSTRAINT [FK_FICHE_INTERVENTION_MAGAZIN] FOREIGN KEY ([CODE_MAG]) REFERENCES [dbo].[MAGAZIN] ([CODE_MAG])
);


GO
ALTER TABLE [dbo].[FICHE_INTERVENTION] NOCHECK CONSTRAINT [FK_FICHE_INTERVENTION_MAGAZIN];


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Date Intervention', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FICHE_INTERVENTION', @level2type = N'COLUMN', @level2name = N'DATE_FI';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'N° Fiche Intervention', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FICHE_INTERVENTION', @level2type = N'COLUMN', @level2name = N'NUM_FI';

