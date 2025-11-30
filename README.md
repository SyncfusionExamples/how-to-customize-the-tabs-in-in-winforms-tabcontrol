# Customization in Windows Forms TabControl (TabControlAdv)
A concise guide to customizing Syncfusion WinForms TabControlAdv appearance and behavior, including runtime tab renaming, drag-reorder, padding, mnemonic handling, border styles, page images (including animated GIFs), and preventing movement of specific tabs.

## Overview
TabControlAdv offers Excel-like label editing, drag-and-drop tab reordering, flexible padding around text/images, mnemonic processing, configurable page borders, and image support on TabPages. The sections below show how to enable and customize each feature.

## Features
- Rename tabs at runtime (LabelEdit)
- Drag-reorder tabs (UserMoveTabs)
- Adjust tab header padding
- Enable/disable mnemonic processing (& as access key)
- Border styles for TabPages and custom FixedSingle border color
- Page images with adjustable size (supports animated GIF)
- Prevent movement of specific tabs

## Renaming TabItems
Enable Excel-like renaming by turning on LabelEdit. Users can right-click and choose rename, double-click the tab header, press Enter to commit, or click elsewhere to exit.

## Moving TabItems
Allow users to change tab order at design time and runtime by dragging tab headers. Enable with UserMoveTabs.

## Padding
Control the space around a tab’s text/image using the Padding property (X, Y).

## UseMnemonic
Determines whether the ampersand (&) in tab text is treated as an access key indicator. Default is false.

## TabPages – Border settings
Configure TabPage border rendering with BorderStyle. When using FixedSingle, you can specify a custom border color via FixedSingleBorderColor.

Supported border styles:
- FixedSingle
- Fixed3D
- None

## Image settings on TabPages (GIF supported)
Assign an image to a TabPage and control its size. Animated GIFs are supported. Note: If ImageIndex is not -1 and an ImageList is attached, the ImageIndex image will be shown instead of the Image property.

## Prevent moving a specific tab
You can keep certain tabs fixed even when UserMoveTabs is enabled. Use the TabMoving event (or related property, if available in your version) to cancel movement for specific tabs.

## Notes
- LabelEdit allows users to enter edit mode by double-clicking a tab or via context actions; press Enter to accept.
- When using ImageList with TabControlAdv, prefer ImageIndex for consistency across tabs.
- API names may vary slightly across versions; refer to your installed Syncfusion WinForms documentation for exact signatures.

## About the Sample
This sample provides a focused starting point for customizing Syncfusion WinForms TabControlAdv. It demonstrates runtime tab renaming, drag-and-drop reordering, header padding adjustments, mnemonic processing, TabPage border styles and custom FixedSingle border color, adding static or animated GIF images with configurable size, and preventing movement of specific tabs. Extend it by adding your own theming, context menus, and command handlers to align with your application’s workflow and branding.
