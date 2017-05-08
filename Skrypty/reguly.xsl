<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/values">
            <result>
                <kilometers>Total kilometers: <xsl:value-of select="format-number(sum(value/km), '###.##')"/></kilometers>
                <calories>Average of calories: <xsl:value-of select="format-number(sum(value/calories), '###.##') div count(value/calories)"/></calories>
                <heartRate>Average of heartRate: <xsl:value-of select="format-number(sum(value/heartRate) div count(value/heartRate), '###.##')"/></heartRate>
            </result>
</xsl:template>
</xsl:stylesheet>