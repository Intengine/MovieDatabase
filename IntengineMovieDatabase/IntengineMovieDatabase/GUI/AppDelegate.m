//
//  AppDelegate.m
//  IntengineMovieDatabase
//
//  Created by Sylwester Pilarz on 05/10/2018.
//  Copyright © 2018 Intengine. All rights reserved.
//

#import "AppDelegate.h"
#include "MasterViewController.h"

@interface AppDelegate ()
@property (nonatomic, strong) IBOutlet MasterViewController *masterViewController;
@property(strong) NSWindow *window;
@end

@implementation AppDelegate

- (void)applicationDidFinishLaunching:(NSNotification *)aNotification {
    self.masterViewController = [[MasterViewController alloc]
                                 initWithNibName:@"MasterViewController" bundle:nil];
    
    [self.window.contentView addSubview:self.masterViewController.view];
    self.masterViewController.view.frame = ((NSView*)self.window.contentView).bounds;
}

- (void)applicationWillTerminate:(NSNotification *)aNotification {
    // Insert code here to tear down your application
}
@end
