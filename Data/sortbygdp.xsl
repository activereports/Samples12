<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:transform xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<countries>
		<xsl:for-each select="//country">
		<xsl:sort select="./GDPPurchasingPowerParity" data-type="number" order="descending" />
			<xsl:if test="@name != 'World' and ./GDPPurchasingPowerParity > 0">
				<country>
					<id><xsl:value-of select="@id"/></id>
					<name><xsl:value-of select="@name"/></name>
					<mapcode><xsl:value-of select="map"/></mapcode>
					<GDPPurchasingPowerParity><xsl:value-of select="./GDPPurchasingPowerParity"/></GDPPurchasingPowerParity>
					<GDPPerCapita><xsl:value-of select="./GDPPerCapita"/></GDPPerCapita>
				</country>
			</xsl:if>
		</xsl:for-each>
		</countries>
	</xsl:template>
</xsl:transform>