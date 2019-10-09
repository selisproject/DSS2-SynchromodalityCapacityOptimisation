$( document ).ready(function(e) {

	$(".oauth-secation").hide();

	$(".authentication-type").on("change", function(e) {
		var $parent = $(this).parent();
		var $basicSection = $parent.find(".basic-secation");
		var $oathSection = $parent.find(".oauth-secation");

		$oathSection.hide();
		$basicSection.hide();

		if ($(this).val() == "basic") {
			$basicSection.show();
		} else if ($(this).val() == "oauth") {
			$oathSection.show();
		}
	});

    /*$.get('../swagger/docs/v1', function (data) {
        var dataStr = "data:text/json;charset=utf-8," + encodeURIComponent(JSON.stringify(data, null, "\t"));
        var $link = $('.download-link');
        $link.attr("href", dataStr);
        $link.attr("download", "swagger.json");
    });*/

    $('form').submit(function(e){
		e.preventDefault(); 
		
		var url = $(this).find(".url").val();
		var method = $(this).find(".method").val();
		var that = this;
		var username = $(".authentication-name").val();
		var password = $(".authentication-password").val();
		var token = $(".authentication-token").val();
		var authType = $(".authentication-type").val();
        var cliendId = $(".clientId").val();
        var clientSecret = $(".clientSecret").val();

		var data = null;
		if (method.toLowerCase() == "get") {
			data = $(this).serializeArray();
		} else {
			var paramterTextAreas = $(this).find(".parameter-value");
			data = {};
			if (paramterTextAreas.length == 1) {
				data = paramterTextAreas[0].value;
			} else {
			    for (var i = 0; i < paramterTextAreas.length; i++) {
			        try {
			            data[paramterTextAreas[i].getAttribute("name")] = JSON.parse(paramterTextAreas[i].value);
			        }
			        catch (e){
			            data[paramterTextAreas[i].getAttribute("name")] = paramterTextAreas[i].value;
			        }
				}

				data = JSON.stringify(data);                
			}
		}
		$(that).next().show();
		$(that).next().html("<img src=\"images/giphy.gif\"/>");
		$.ajax({
            type: method,
            url: url,
		    dataType: 'json',
			contentType: "application/json",
            data: data,
			// data:$(this).find("textarea").val(),
			beforeSend: function (xhr) {
				if (authType == "basic" && username != undefined && username!=null && password!=undefined && password!=null){
			 		xhr.setRequestHeader("Authorization", "Basic " + btoa(username + ":" + password));
			 	} else if (authType == "oauth" && token != undefined && token != null && token != "") {
		 			xhr.setRequestHeader("Authorization", "Bearer " + token);
			 	}
                if(cliendId.length>0){
                    xhr.setRequestHeader("X-CLMSAPI-ClientId", cliendId);
                }
                if(clientSecret.length>0){
                    xhr.setRequestHeader("X-CLMSAPI-ClientSecret", clientSecret);
                }

			 },
            success: function(result, request,xhr)
            {	
				
				$(that).next().show();
				if (result == null){
					$(that).next().html("<h3>Response</h3><button value=\"Copy\" class='copyButton'>Copy</button><br/><pre><span class=\"nt\">" + xhr.status + " " + xhr.statusText + "</span></br>" + "<span class=\"nt\">Content-type</span>: " + xhr.getResponseHeader("Content-Type") + "</br>No content</<pre>");
					
				}else{
					
					$(that).next().html("<h3>Response</h3><button value=\"Copy\" class='copyButton'>Copy</button><br/><pre><span class=\"nt\">" + xhr.status + " " + xhr.statusText + "</span></br>" + "<span class=\"nt\">Content-type</span>: " + xhr.getResponseHeader("Content-Type") + "</br>" + syntaxHighlight(JSON.stringify(result, null, "\t")) + "</pre>");
				}
			    
               
           },
		    error:function(data){
				$(that).next().show();
				
			    $(that).next().html("<h3>Response</h3><button value=\"Copy\" class='copyButton'>Copy</button><br/><pre><span class=\"nt\">" + data.status + " " + data.statusText + "</span></br>" + "<span class=\"nt\">Content-type</span>: " + data.getResponseHeader("Content-Type") + "</br>" + syntaxHighlight(JSON.stringify(data.responseJSON, null, "\t")) + "</pre>");
			    
			   
		    }
          });


	})
	$(".sample").on("click",function(e){
		
		$(e.target).closest("td").prev().find('.parameter-value').val($(this).text());
		
	});
	
	$(".getDefaultValue").on("click",function(e){
		
		$(e.target).prev('.parameter-value').val($(e.target).closest("td").next().find(".sample").text());
		
	})
	$("body").on("click",".copyButton",function(e){
		
			var $temp = $("<input>");
		  $("body").append($temp);
		  $temp.val($(e.target).next().next().text()).select();
		  
		  document.execCommand("copy");
		  $temp.remove();
	});
	function syntaxHighlight(json) {
    if (typeof json != 'string') {
         json = JSON.stringify(json, undefined, 2);
    }
    json = json.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
    return json.replace(/("(\\u[a-zA-Z0-9]{4}|\\[^u]|[^\\"])*"(\s*:)?|\b(true|false|null)\b|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)/g, function (match) {
        var cls = 'number';
        if (/^"/.test(match)) {
            if (/:$/.test(match)) {
                cls = 'key';
            } else {
                cls = 'string';
            }
        } else if (/true|false/.test(match)) {
            cls = 'boolean';
        } else if (/null/.test(match)) {
            cls = 'null';
        }
        return '<span class="' + cls + '">' + match + '</span>';
    });
}
});