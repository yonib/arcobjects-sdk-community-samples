'Copyright 2016 Esri

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at

'    http://www.apache.org/licenses/LICENSE-2.0

'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

'See the License for the specific language governing permissions and
'limitations under the License.
Imports Microsoft.VisualBasic
Imports System
Imports ESRI.ArcGIS.Display

Namespace GlobeGraphicsToolbar
	Public Class StyleGallerySelection
		Private Shared _styleGalleryItem As IStyleGalleryItem = Nothing

		Public Shared Sub SetStyleGalleryItem(ByVal styleGalleryItem As IStyleGalleryItem)
			_styleGalleryItem = styleGalleryItem
		End Sub

		Public Shared Function GetStyleGalleryItem() As IStyleGalleryItem
			Return _styleGalleryItem
		End Function
	End Class
End Namespace