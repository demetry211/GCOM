CREATE TABLE [dbo].[LG_DC] (
    [CODE_DC]       NVARCHAR (20)   NOT NULL,
    [CODE_ARTICLE]  DECIMAL (18)    NOT NULL,
    [QTE]           DECIMAL (18, 3) NOT NULL,
    [UNITE]         NCHAR (10)      CONSTRAINT [DF_LG_DC_UNITE] DEFAULT ('') NOT NULL,
    [PRIX_U_HT]     DECIMAL (18, 3) CONSTRAINT [DF_LG_DC_PRIX_U_HT] DEFAULT ((0)) NOT NULL,
    [FODEC]         DECIMAL (18, 3) CONSTRAINT [DF_LG_DC_FODEC] DEFAULT ((0)) NOT NULL,
    [REMISE]        DECIMAL (18)    CONSTRAINT [DF_LG_DC_REMISE] DEFAULT ((0)) NOT NULL,
    [TVA]           DECIMAL (18, 3) CONSTRAINT [DF_LG_DC_TVA] DEFAULT ((0)) NOT NULL,
    [PRIX_HT_ACHAT] DECIMAL (18, 3) CONSTRAINT [DF_LG_DC_PRIX_TVA_ACHAT] DEFAULT ('0') NOT NULL,
    [TVA_ACHAT]     DECIMAL (18, 3) CONSTRAINT [DF_LG_DC_TVA_ACHAT] DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK_LG_DC] PRIMARY KEY CLUSTERED ([CODE_DC] ASC, [CODE_ARTICLE] ASC),
    CONSTRAINT [FK_LG_DC_ARTICLE] FOREIGN KEY ([CODE_ARTICLE]) REFERENCES [dbo].[ARTICLE] ([CODE_ARTICLE]),
    CONSTRAINT [FK_LG_DC_DEVIS_CLIENT] FOREIGN KEY ([CODE_DC]) REFERENCES [dbo].[DEVIS_CLIENT] ([CODE_DC])
);


GO
ALTER TABLE [dbo].[LG_DC] NOCHECK CONSTRAINT [FK_LG_DC_DEVIS_CLIENT];


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'TVA', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LG_DC', @level2type = N'COLUMN', @level2name = N'TVA';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Remise', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LG_DC', @level2type = N'COLUMN', @level2name = N'REMISE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Fodec', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LG_DC', @level2type = N'COLUMN', @level2name = N'FODEC';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'P. U. HT', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LG_DC', @level2type = N'COLUMN', @level2name = N'PRIX_U_HT';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Unité', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LG_DC', @level2type = N'COLUMN', @level2name = N'UNITE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Qté', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LG_DC', @level2type = N'COLUMN', @level2name = N'QTE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code Article', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LG_DC', @level2type = N'COLUMN', @level2name = N'CODE_ARTICLE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Code DC', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LG_DC', @level2type = N'COLUMN', @level2name = N'CODE_DC';

