      <!-- Initial duration is in seconds. Manipulate it into a readable string -->
                                            <xsl:value-of select="format-number(floor(@duration div (60 * 60)), '0')" /> hours
                                            <xsl:value-of select="format-number(floor((@duration div 60) mod 60), '0')" /> minutes
                                            <xsl:value-of select="format-number(floor(@duration mod 60), '0')" /> seconds
                                        </b>
                                    </p>
                                    <p>Disconnect Reason:<b><xsl:value-of select="@disconnect" /></b></p>
                                </xsl:when>
                            </xsl:choose>
                            <table>
                                <xsl:choose>
                                    <xsl:when test="@success = 0">
                                        <!--Successful session-->
                                        <tr class="successful">
                                            <th class="event-header">EventId</th>
                                            <th class="time-header">Time</th>
                                            <th class="message-header">Message</th>
                                        </tr>
                                    </xsl:when>
                                    <xsl:when test="@success = 1">
                                        <!--Warning session-->
                                        <tr class="warning">
                                            <th class="event-header">EventId</th>
                                            <th class="time-header">Time</th>
                                            <th class="message-header">Message</th>
                                        </tr>
                                    </xsl:when>
                                    <xsl:when test="@success = 3">
                                        <!--Info session-->
                                        <tr class="info">
                                            <th class="event-header">EventId</th>
                                            <th class="time-header">Time</th>
                                            <th class="message-header">Message</th>
                                        </tr>
                                    </xsl:when>
                                    <xsl:otherwise>
                                        <tr class="failed">
                                            <th class="event-header">EventId</th>
                                            <th class="time-header">Time</th>
                                            <th class="message-header">Message</th>
                                        </tr>
                                    </xsl:otherwise>
                                </xsl:choose>
                                <xsl:for-each select="WlanEvent">
                                    <tr>
                                        <xsl:attribute name="class">
                                            <xsl:choose>
                                                <xsl:when test="@error > 0">
                                                    error
                                                </xsl:when>
                                                <xsl:otherwise>
                                                    <xsl:value-of select="@type" />
                                                </xsl:otherwise>
                                            </xsl:choose>
                                        </xsl:attribute>
                                        <td>
                                          