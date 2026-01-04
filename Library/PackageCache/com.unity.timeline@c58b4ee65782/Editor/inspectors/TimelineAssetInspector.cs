,this.div_favicon=this.root.querySelector("#div_favicon")}metaHasChanged(o){this.meta=o,o.favicon_url.isSome()?this.div_favicon.style.backgroundImage=`url(${o.favicon_url.value.href})`:$(this.div_favicon)}init(o,r,i){V(this.root,i),this.media=o,this.meta=r;let t=!1;"duration"in o?(T(this.p_duration),typeof o.duration=="number"?(this.p_duration.textContent=dr(o.duration),(o.type=="m3u8_playlist"||o.type=="youtube_format"||o.type=="mpd_playlist")&&(t=!0)):o.duration=="live"?this.p_duration.textContent="live":$(this.p_duration)):$(this.p_duration),"size"in o?o.size.isSome()?this.p_size.textContent=ge(o.size.value):$(this.p_size):$(this.p_size),Y(this.p_star,t),this.metaHasChanged(r)}};var wr=class extends HTMLElement{constructor(){super(),this.attachShadow({mode:"open"});let o=document.querySelector("#media-tags-template"),r=this.shadowRoot;r.appendChild(o.content.cloneNode(!0)),this.tag_hls=r.querySelector("#hls"),this.tag_m3u8=r.querySelector("#m3u8"),this.tag_http=r.querySelector("#http"),this.tag_yt=r.querySelector("#yt"),this.tag_mpd=r.querySelector("#mpd")}init(o,r){if(V(this.shadowRoot,r),o.type=="m3u8_playlist")T(this.tag_hls);else if(o.type=="m3u8")T(this.tag_m3u8);else if(o.type=="http")T(this.tag_http);else if(o.type=="youtube_format")T(this.tag_yt);else if(o.type=="mpd_playlist")T(this.tag_mpd);else{let i=o}}};var rd=ae(te(),1);var xr=class extends HTMLElement{constructor(){super();this.url="";this.attachShadow({mode:"open"});let r=document.querySelector("#media-button-origin");this.root=this.shadowRoot,this.root.appendChild(r.content.cloneNode(!0)),this.span_hostname=this.root.querySelector("#span_hostname"),this.div_favicon=this.root.querySelector("#div_favicon"),this.button_origin=this.root.querySelector("#button_origin"),this.box_drm=this.root.querySelector("#box_drm")}init(r,i,t,n){V(this.shadowRoot,n),this.span_hostname.textContent=r.hostname,i?this.div_favicon.style.backgroundImage=`url(${i})`:this.div_favicon.style.backgroundImage="unset",this.button_origin.onclick=()=>{rd.default.tabs.create({url:r.href})},Y(this.box_drm,t)}};var kr=class extends HTMLElement{constructor(){super(),this.attachShadow({mode:"open"});let o=document.querySelector("#button-dismiss-template");this.shadowRoot.appendChild(o.content.cloneNode(!0))}};var Sr=class extends HTMLElement{constructor(){super(),this.attachShadow({mode:"open"});let o=document.querySelector("#report-button-template");this.root=this.shadowRoot,this.root.appendChild(o.content.cloneNode(!0)),this.button_report=this.root.querySelector("#button_report"),this.button_reporting=this.root.querySelector("#button_reporting"),this.button_reported=this.root.querySelector("#button_reported")}init(o,{on_click:r}){V(this.root,o),this.button_report.onclick=async()=>{$(this.button_report),T(this.button_reporting),$(this.button_reported),await r(),$(this.button_report),$(this.button_reporting),T(this.button_reported)}}reset(){T(this.button_report),$(this.button_reporting),$(this.button_reported)}};function nd(){window.customElements.define("com-notification",ur),window.customElements.define("com-debug",cr),window.customElements.define("com-native-menu",pr),window.customElements.define("com-dismiss-button",kr),window.customElements.define("com-media",_r),window.customElements.define("com-media-preview",mr),window.customElements.define("com-media-discovered",gr),window.customElements.define("com-media-downloading",hr),window.customElements.define("com-media-downloaded",yr),window.customElements.define("com-media-selector",vr),window.customElements.define("com-media-meta",br),window.customElements.define("com-media-tags",wr),window.customElements.define("com-media-button-origin",xr),window.customElements.define("com-report-button",Sr)}nd();var zr=await ar(),ep=await ir();V(document,zr.custom_strings.addon),Xt(e=>{e.name=="reload"&&window.location.reload()});var tp=await id.default.runtime.getPlatformInfo();document.body.setAttribute("os",tp.os);var op=document.querySelector("#button_report"),ad=window.location.hash.substring(1),$r=zr.downloaded.get(ad);if(!$r){for(let e of ep.transient_history)if(e.downloaded_id===ad){$r=e;break}}document.documentElement.setAttribute("theme",zr.ui_theme);op.init(zr.custom_strings.addon,{on_click:async()=>{if($r)return Bu($r)}});
/*! Bundled license information:

smol-toml/dist/error.js:
smol-toml/dist/util.js:
smol-toml/dist/date.js:
smol-toml/dist/primitive.js:
smol-toml/dist/extract.js:
smol-toml/dist/struct.js:
smol-toml/dist/parse.js:
smol-toml/dist/stringify.js:
smol-toml/dist/index.js:
  (*!
   * Copyright (c) Squirrel Chat et al., All rights reserved.
   * SPDX-License-Identifier: BSD-3-Clause
   *
   * Redistribution and use in source and binary forms, with or without
   * modification, are permitted provided that the following conditions are met:
   *
   * 1. Redistributions of source code must retain the above copyright notice, this
   *    list of conditions and the following disclaimer.
   * 2. Redistributions in binary form must reproduce the above copyright notice,
   *    this list of conditions and the following disclaimer in the
   *    documentation and/or other materials provided with the distribution.
   * 3. Neither the name of the copyright holder nor the names of its contributors
   *    may be used to endorse or promote products derived from this software without
   *    specific prior written permission.
   *
   * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
   * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
   * WARRANTIES OF 